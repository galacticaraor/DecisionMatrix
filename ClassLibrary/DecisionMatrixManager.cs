using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ClassLibrary
{
    public class DecisionMatrixManager
    {
        private readonly IStorage _storage;

        public DecisionMatrixManager(IStorage storage)
        {
            _storage = storage;
        }

        public List<DecisionMatrix> Search(string keyword)
        {
            List<DecisionMatrix> decisionMatrixes = _storage.LoadDecisionMatrixes();
            if (!string.IsNullOrEmpty(keyword))
            {
                //Return the filtered results by keyword
                return decisionMatrixes.FindAll(x => x.Name.ToLower().Contains(keyword.ToLower()));
            }
            else
            {
                //Return the raw results
                return decisionMatrixes;
            }
        }

        public FileResult Add(DecisionMatrix decisionMatrix)
        {
            List<DecisionMatrix> decisionMatrixes = _storage.LoadDecisionMatrixes();
            //Append the decision matrix
            decisionMatrixes.Add(decisionMatrix);
            FileResult fileResult = _storage.SaveDecisionMatrixes(decisionMatrixes);
            return fileResult;
        }

        public FileResult Edit(DecisionMatrix decisionMatrix) {
            List<DecisionMatrix> decisionMatrixes = _storage.LoadDecisionMatrixes();
            //Find the decision matrix to edit and replace it
            DecisionMatrix dm = decisionMatrixes.Find(x => x.UUID == decisionMatrix.UUID);
            dm.Name = decisionMatrix.Name;
            dm.DateUpdated = DateTime.Now;
            dm.Pros.Clear();
            foreach (Factor f in decisionMatrix.Pros)
            {
                dm.AddPro(f);
            }
            dm.Cons.Clear();
            foreach (Factor f in decisionMatrix.Cons)
            {
                dm.AddCon(f);
            }
            FileResult fileResult = _storage.SaveDecisionMatrixes(decisionMatrixes);
            return fileResult;
        }

        public FileResult Delete(string uuid)
        {
            List<DecisionMatrix> decisionMatrixes = _storage.LoadDecisionMatrixes();
            //Find the decision matrix to delete and delete it
            DecisionMatrix dm = decisionMatrixes.Find(x => x.UUID == uuid);
            decisionMatrixes.Remove(dm);
            FileResult fileResult = _storage.SaveDecisionMatrixes(decisionMatrixes);
            return fileResult;
        }

        public DecisionMatrix Get(string uuid)
        {
            List<DecisionMatrix> decisionMatrixes = _storage.LoadDecisionMatrixes();
            //Find the decision matrix to retrieve
            DecisionMatrix dm = decisionMatrixes.Find(x => x.UUID == uuid);
            //If found then
            if (dm != null)
            {
                return dm;
            }
            else
            {
                return new DecisionMatrix();
            }
        }

    }
}