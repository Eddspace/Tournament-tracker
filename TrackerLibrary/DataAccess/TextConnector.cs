using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;

namespace TrackerLibrary.DataAccess;

public class TextConnector : IDataConnection
{
    private const string PrizesFile = "PrizeModels.csv";
    private const string PeopleFile = "PersonModels.csv";
    private const string TeamFile = "TeamModels.csv";

    public PersonModel CreatePerson(PersonModel model)
    {
        List<PersonModel> people = PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();

        int currentId = 1;
        if (people.Count > 0)
        {
            currentId = people.OrderByDescending(x => x.Id).First().Id + 1;
        }
        model.Id = currentId;

        people.Add(model);

        people.SaveToPeopleFile(PeopleFile);

        return model;
    }

    public PrizeModel CreatePrize(PrizeModel model)
    {
        //load txt file & convert to list
        List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

        //find last ID
        int currentId = 1;
        if (prizes.Count > 0)
        {
            currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
        }
        model.Id = currentId;

        //add new record with new id
        prizes.Add(model);

        //convert all to a list & replace txt with new list
        prizes.SaveToPrizeFile(PrizesFile);

        return model;
    }

    public TeamModel CreateTeam(TeamModel model)
    {
        List<TeamModel> teams = TeamFile.FullFilePath().LoadFile().ConvertToTeamModels(PeopleFile);

        int currentId = 1;
        if (teams.Count > 0)
        {
            currentId = teams.OrderByDescending(x => x.Id).First().Id + 1;
        }
        model.Id = currentId;

        teams.Add(model);

        teams.SaveToTeamFile(TeamFile);

        return model;

    }

    public List<PersonModel> GetPerson_all()
    {
        return PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();
    }

    public List<TeamModel> GetTeam_all()
    {
        throw new NotImplementedException();
    }
}
