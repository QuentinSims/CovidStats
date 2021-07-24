using System;
using System.Collections.Generic;
using System.IO;

namespace CovidStats
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo covidDirectory = new DirectoryInfo(currentDirectory);
            var fileName = Path.Combine(covidDirectory.FullName, "covid deaths.csv");
            var fileContents = ReadCovidResults(fileName);
        }

        public static string ReadFile(string fileName)
        {
            using (var reader = new StreamReader(fileName))
            {
                return reader.ReadToEnd();
            }
        }

        public static List<CovidResults> ReadCovidResults(string fileName)
        {
            var covidData = new List<CovidResults>();
            using (var reader = new StreamReader(fileName))
            {
                string line = "";
                reader.ReadLine();
                while ((line = reader.ReadLine()) != null)
                {
                    var covidResults = new CovidResults();
                    string[] values = line.Split(';');

                    covidResults.isoCode = values[0];
                    covidResults.Continent = values[1];
                    covidResults.Location = values[2];

                    covidResults.Date = DateTime.Parse(values[3]);
                    DateTime date;
                    if (DateTime.TryParse(values[3], out date))
                    {
                        covidResults.Date = date;
                    }
                    decimal parseDecimal;
                    if (decimal.TryParse(values[4].Replace(".", ","), out parseDecimal))
                    {
                        covidResults.Popluation = parseDecimal;
                    }
                    if (decimal.TryParse(values[5].Replace(".", ","), out parseDecimal))
                    {
                        covidResults.TotalCases = parseDecimal;
                    }
                    if (decimal.TryParse(values[6].Replace(".", ","), out parseDecimal))
                    {
                        covidResults.NewCases = parseDecimal;
                    }
                    if (decimal.TryParse(values[7].Replace(".", ","), out parseDecimal))
                    {
                        covidResults.NewCasesSmoothed = parseDecimal;
                    }
                    if (decimal.TryParse(values[8].Replace(".", ","), out parseDecimal))
                    {
                        covidResults.TotalDeaths = parseDecimal;
                    }
                    if (decimal.TryParse(values[9].Replace(".", ","), out parseDecimal))
                    {
                        covidResults.NewDeaths = parseDecimal;
                    }
                    if (decimal.TryParse(values[10].Replace(".", ","), out parseDecimal))
                    {
                        covidResults.NewDeathsSmoothed = parseDecimal;
                    }
                    if (decimal.TryParse(values[11].Replace(".", ","), out parseDecimal))
                    {
                        covidResults.TotalCasesPerMillion = parseDecimal;
                    }
                    if (decimal.TryParse(values[12].Replace(".", ","), out parseDecimal))
                    {
                        covidResults.NewCasesPerMillion = parseDecimal;
                    }
                    if (decimal.TryParse(values[13].Replace(".", ","), out parseDecimal))
                    {
                        covidResults.NewCasesSmoothedPerMillion = parseDecimal;
                    }
                    if (decimal.TryParse(values[14].Replace(".", ","), out parseDecimal))
                    {
                        covidResults.TotalDeathsPerMillion = parseDecimal;
                    }
                    if (decimal.TryParse(values[15].Replace(".", ","), out parseDecimal))
                    {
                        covidResults.NewDeathsPerMillion = parseDecimal;
                    }
                    if (decimal.TryParse(values[16].Replace(".", ","), out parseDecimal))
                    {
                        covidResults.NewDeathSmoothedPerMillion = parseDecimal;
                    }
                    if (decimal.TryParse(values[17].Replace(".", ","), out parseDecimal))
                    {
                        covidResults.ReproductionRate = parseDecimal;
                    }
                    if (decimal.TryParse(values[18].Replace(".", ","), out parseDecimal))
                    {
                        covidResults.IcuPatients = parseDecimal;
                    }
                    if (decimal.TryParse(values[19].Replace(".", ","), out parseDecimal))
                    {
                        covidResults.IcuPatientsPerMillion = parseDecimal;
                    }
                    if (decimal.TryParse(values[20].Replace(".", ","), out parseDecimal))
                    {
                        covidResults.HospPatients = parseDecimal;
                    }
                    if (decimal.TryParse(values[21].Replace(".", ","), out parseDecimal))
                    {
                        covidResults.HospPatientsPerMillion = parseDecimal;
                    }
                    if (decimal.TryParse(values[22].Replace(".", ","), out parseDecimal))
                    {
                        covidResults.WeeklyIcuAdmissions = parseDecimal;
                    }
                    if (decimal.TryParse(values[23].Replace(".", ","), out parseDecimal))
                    {
                        covidResults.WeeklyHospAdmissionsPerMillion = parseDecimal;
                    }
                    if (decimal.TryParse(values[24].Replace(".", ","), out parseDecimal))
                    {
                        covidResults.WeeklyHospAdmissions = parseDecimal;
                    }
                    if (decimal.TryParse(values[25].Replace(".", ","), out parseDecimal))
                    {
                        covidResults.WeeklyHospAdmissionsPerMillion = parseDecimal;
                    }

                    covidData.Add(covidResults);
                }
            }
            return covidData;
        }
    }
}
