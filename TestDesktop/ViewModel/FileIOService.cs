using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDesktop.Model;

namespace TestDesktop.ViewModel
{
    internal class FileIOService
    {
        private readonly string PATH;

        public FileIOService (string path)
        {
            PATH = path;   
        }
        public BindingList<SolutionF> LoadData() 
        {
            var fileExists = File.Exists (PATH);   
            if(!fileExists)
            {
                File.CreateText(PATH).Dispose();
                return new BindingList<SolutionF> ();
            }

            using (var reader = File.OpenText(PATH))
            {
                var fileText = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<BindingList<SolutionF>>(fileText);
            }
        }

        public void SaveData(object todoDataList)
        {
            using (StreamWriter writer = File.CreateText(PATH))
            {
                string output = JsonConvert.SerializeObject(todoDataList);
                writer.WriteLine(output); 
            }
        }
    }
}
