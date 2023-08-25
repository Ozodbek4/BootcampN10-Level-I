using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace N28Home1.DataAccess
{
    internal class FileSet<T> : List<T>
    {
        private readonly string _name;
        public FileSet(string name)
        {
            _name = name;
        }

        public void Initialize()
        {
            var fileName = $"{_name.ToLower()}";
            var folderName = Path.Combine(Directory.GetCurrentDirectory(), "Storage");
            var filePath = Path.Combine(folderName, fileName);
            if (!File.Exists(filePath))
            {
                return;
            }

            var fileStream = File.Open(filePath, FileMode.Open);
            var previousData = JsonSerializer.Deserialize<List<T>>(fileStream);

            Clear();
            AddRange(previousData);

            fileStream.Flush();
            fileStream.Close();
        }

        public void SaveChanges()
        {
            var fileName = $"{_name.ToLower()}.json";
            var folderName = Path.Combine()
        }
    }
}
