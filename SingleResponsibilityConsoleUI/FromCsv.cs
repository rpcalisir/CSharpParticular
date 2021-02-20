using CsvHelper;
using SingleResponsibilityConsoleUI.PersonOperations;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityConsoleUI
{
    public class FromCsv
    {
        public static Person ConvertFromCsv(string csvLine)
        {
            Person person = new Person();

            string[] values = csvLine.Split(',');
            person.FirstName = values[0];
            person.LastName = values[1];

            return person;
        }

        public static IEnumerable<Person> GetFromCsv(string csv)
        {
            TextReader textReader = new StringReader(csv);

            CsvReader csvr = new CsvReader(textReader,CultureInfo.CurrentCulture);
            var records = csvr.GetRecords<Person>();
            return records;
        }
    }
}
