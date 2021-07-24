using CsvHelper.Configuration.Attributes;
using System;

namespace CovidStats
{
    public class CovidResults
    {
        [Name("iso_code")]
        public string isoCode { get; set; }

        [Name("continent")]
        public string Continent { get; set; }

        [Name("location")]
        public string Location { get; set; }

        [Name("date")]
        public DateTime Date { get; set; }

        [Name("popluation")]
        public decimal Popluation { get; set; }

        [Name("total_cases")]
        public decimal TotalCases { get; set; }

        [Name("new_cases")]
        public decimal NewCases { get; set; }

        [Name("new_cases_smoothed")]
        public decimal NewCasesSmoothed { get; set; }

        [Name("total_deaths")]
        public decimal TotalDeaths { get; set; }

        [Name("new_deaths")]
        public decimal NewDeaths { get; set; }

        [Name("new_deaths_smoothed")]
        public decimal NewDeathsSmoothed { get; set; }

        [Name("total_cases_per_million")]
        public decimal TotalCasesPerMillion { get; set; }

        [Name("new_cases_per_million")]
        public decimal NewCasesPerMillion { get; set; }

        [Name("new_cases_smoothed_per_million")]
        public decimal NewCasesSmoothedPerMillion { get; set; }

        [Name("Total_deaths_per_million")]
        public decimal TotalDeathsPerMillion { get; set; }

        [Name("new_deaths_per_million")]
        public decimal NewDeathsPerMillion { get; set; }

        [Name("new_deaths_smoothed_per_million")]
        public decimal NewDeathSmoothedPerMillion { get; set; }

        [Name("reproduction_rate")]
        public decimal ReproductionRate { get; set; }

        [Name("icu_patients")]
        public decimal IcuPatients { get; set; }

        [Name("icu_patients_per_million")]
        public decimal IcuPatientsPerMillion { get; set; }

        [Name("hosp_patients")]
        public decimal HospPatients { get; set; }

        [Name("hosp_patients_per_million")]
        public decimal HospPatientsPerMillion { get; set; }

        [Name("weekly_icu_admissions")]
        public decimal WeeklyIcuAdmissions { get; set; }

        [Name("weekly_icu_admissions_per_million")]
        public decimal WeeklyIcuAdmissionsPerMillion { get; set; }

        [Name("weekly_hosp_admissions")]
        public decimal WeeklyHospAdmissions { get; set; }

        [Name("weekly_hosp_admissions_per_million")]
        public decimal WeeklyHospAdmissionsPerMillion { get; set; }







    }
}
