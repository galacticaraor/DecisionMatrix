using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using ClassLibrary;

namespace DAL
{
    public class JsonStorage: IStorage
    {
        public string Path { get; set; }
        public JsonStorage(string path)
        {
            Path = path;
        }

        public List<DecisionMatrix> LoadDecisionMatrixes()
        {
            //If the path exists then
            if (File.Exists(Path))
            {
                string json = "";
                //Read the file from the file system
                using (TextReader reader = File.OpenText(Path))
                {
                    json = reader.ReadToEnd();
                }
                //Deserialize the JSON
                List<DecisionMatrix> decisionMatrixes = JsonConvert.DeserializeObject<List<DecisionMatrix>>(json);
                return decisionMatrixes;
            }
            else
            {
                return new List<DecisionMatrix>();
            }
        }

        public FileResult SaveDecisionMatrixes(List<DecisionMatrix> decisionMatrixes)
        {
            FileResult fileResult = new FileResult(true, "");
            //Serialize the object
            string json = JsonConvert.SerializeObject(decisionMatrixes);
            try
            {
                //Save the decision matrix JSON to a JSON file
                using (TextWriter writer = File.CreateText(Path))
                {
                    writer.Write(json);
                }
                return fileResult;
            }
            catch (Exception ex)
            {
                fileResult.Successful = false;
                fileResult.Error = ex.Message;
                return fileResult;
            }
        }
    }
}
