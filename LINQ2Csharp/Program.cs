
Company[] companies = new Company[]
        {
            new Company("Global Foods", new DateTime(2015, 4, 1), "Food", "John White", 250, "London"),
            new Company("Tech Innovators", new DateTime(2018, 7, 15), "IT", "Michael Black", 300, "San Francisco"),
            new Company("Marketing Gurus", new DateTime(2017, 2, 20), "Marketing", "Emily Johnson", 150, "New York"),
            new Company("White House Designs", new DateTime(2020, 9, 5), "Design", "Anna White", 50, "London"),
            new Company("Fast Foodies", new DateTime(2019, 3, 10), "Food", "Robert Brown", 120, "Chicago"),
            new Company("Tech Alliance", new DateTime(2016, 5, 25), "IT", "Sarah Davis", 500, "Austin"),
            new Company("Creative Minds", new DateTime(2021, 1, 12), "Marketing", "Chris Black", 90, "Seattle"),
            new Company("Food & Fun", new DateTime(2014, 11, 3), "Food", "Laura Smith", 200, "Boston"),
            new Company("Innovative Solutions", new DateTime(2012, 6, 8), "IT", "Paul Black", 400, "San Diego"),
            new Company("London Delights", new DateTime(2020, 8, 15), "Food", "Elizabeth White", 130, "London")
        };

var linq1 = from company in companies
            select company;

var ext1 = companies.Select(company => company);

var linq2 = from company in companies
            where company.Name.Contains("Food")
            select company;

var ext2 = companies.Where(company => company.Name.Contains("Food"));

var linq3 = from company in companies
            where company.Profile == "Marketing"
            select company;

var ext3 = companies.Where(company => company.Profile == "Marketing");

var linq4 = from company in companies
            where company.Profile == "Marketing" || company.Profile == "IT"
            select company;

var ext4 = companies.Where(company => company.Profile == "Marketing" || company.Profile == "IT");

var linq5 = from company in companies
            where company.EmployeeCount > 100
            select company;

var ext5 = companies.Where(company => company.EmployeeCount > 100);

var linq6 = from company in companies
            where company.EmployeeCount > 100 && company.EmployeeCount < 300
            select company;

var ext6 = companies.Where(company => company.EmployeeCount > 100 && company.EmployeeCount < 300);

var linq7 = from company in companies
            where company.Adress.Contains("London")
            select company;

var ext7 = companies.Where(company => company.Adress.Contains("London"));

var linq8 = from company in companies
            where company.CEOName.Contains("White")
            select company;

var ext8 = companies.Where(company => company.CEOName.Contains("White"));


class Company
{
    public string Name { get; set; }
    public DateTime Founded { get; set; }
    public string Profile { get; set; }
    public string CEOName { get; set; }
    public int EmployeeCount { get; set; }
    public string Adress { get; set; }

    public Company(string name, DateTime founded, string profile, string ceoname, int employeeCount, string adress)
    {
        Name = name;
        Founded = founded;
        Profile = profile;
        CEOName = ceoname;
        EmployeeCount = employeeCount;
        Adress = adress;
    }

    public override string ToString()
    {
        return $"{Name}\nFounded in {Founded}\nBussiness profile {Profile}\nCEO is {CEOName}\nWith {EmployeeCount} employees\nBased in {Adress}";
    }

}