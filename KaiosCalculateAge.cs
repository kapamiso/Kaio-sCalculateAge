//Algorithm done by Kaio Patrick
//Linkedin: https://www.linkedin.com/in/kaio-patrick-0b5435138/

DateTime startDate = new DateTime(1990, 1, 5);
DateTime endDate = DateTime.Now;

//OutPut testing
Console.WriteLine(AgeDays(startDate, endDate));
Console.WriteLine(AgeMonths(startDate, endDate));
Console.WriteLine(AgeYear(startDate, endDate));


//get how many days from your start date to end date and remove complete months, since it's on month's var
int AgeDays(DateTime startDate, DateTime endDate)
{
    int ageDays = 0;

    if (startDate.Day < endDate.Day)
    {
        ageDays = endDate.Day - startDate.Day;
    }
    else
    {
        ageDays = 40 - startDate.Day;
    }

    if(startDate.Date >= endDate.Date)
    {
        ageDays = 0;
    }

    return ageDays;
}




//GET HOW MANY MONTHS
int AgeMonths(DateTime startDate, DateTime endDate)
{
    int ageMonths = 0;
    DateTime lastBirthday = getLastBirthday(startDate, endDate);

    for (DateTime date = lastBirthday; date < endDate; date.AddMonths(1))
    {
        date = date.AddMonths(1);
        ageMonths = ageMonths + 1;

    }
    ageMonths = ageMonths - 1;

    if(ageMonths < 0 || startDate.Date >= endDate.Date)
    {
        ageMonths = 0;
    }



    return ageMonths;
}

//GET HOW MANY YEARS
int AgeYear(DateTime startDate, DateTime endDate)
{
    int ageYear = 0;
    DateTime lastBirthday = getLastBirthday(startDate, endDate);

    if (startDate.Month <= endDate.Month && startDate.Day < endDate.Day)
    {
        ageYear = endDate.Year - startDate.Year;
        
    }
    else
    {

        ageYear = endDate.Year - startDate.Year - 1;

    }

    if(ageYear < 0) 
    {
        ageYear = 0;
    }

    return ageYear;
}



//GET WHEN WAS YOUR LAST BIRTHDAY
DateTime getLastBirthday(DateTime startDate, DateTime endDate)
{
    DateTime lastBirthDay = new DateTime();

    //checando se último aniversário foi nesse ano ou no passado
    if (startDate.Year == endDate.Year)
    {
        lastBirthDay = new DateTime(endDate.Year, startDate.Month, startDate.Day);

    }
    else
    {
        lastBirthDay = new DateTime(endDate.Year - 1, startDate.Month, startDate.Day);
    }

    return lastBirthDay;
}
