using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;

namespace TrackerLibrary.DataAccess;

public class TextConnector : IDataConnection
{

    public void CreatePerson(PersonModel model)
    {
        List<PersonModel> people = GlobalConfig.PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();

        int currentId = 1;
        if (people.Count > 0)
        {
            currentId = people.OrderByDescending(x => x.Id).First().Id + 1;
        }
        model.Id = currentId;

        people.Add(model);

        people.SaveToPeopleFile();
    }

    public void CreatePrize(PrizeModel model)
    {
        //load txt file & convert to list
        List<PrizeModel> prizes = GlobalConfig.PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

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
        prizes.SaveToPrizeFile();
    }

    public void CreateTeam(TeamModel model)
    {
        List<TeamModel> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModels();

        int currentId = 1;
        if (teams.Count > 0)
        {
            currentId = teams.OrderByDescending(x => x.Id).First().Id + 1;
        }
        model.Id = currentId;

        teams.Add(model);

        teams.SaveToTeamFile();
    }

    public void CreateTournament(TournamentModel model)
    {
        List<TournamentModel> tournaments = GlobalConfig.TournamentFile.FullFilePath().LoadFile().ConvertToTournamentModels();

        int currentId = 1;
        if (tournaments.Count > 0)
        {
            currentId = tournaments.OrderByDescending(x => x.Id).First().Id + 1;
        }
        model.Id = currentId;

        model.SaveRoundsToFile();

        tournaments.Add(model);

        tournaments.SaveToTournamentFile();

        TournamentLogic.UpdateTournamentResults(model);

    }

    public void CompleteTournament(TournamentModel model)
    {
        List<TournamentModel> tournaments = GlobalConfig.TournamentFile.FullFilePath().LoadFile().ConvertToTournamentModels();

        tournaments.Remove(model);
        tournaments.SaveToTournamentFile();

        TournamentLogic.UpdateTournamentResults(model);
    }

    public List<PersonModel> GetPerson_all()
    {
        return GlobalConfig.PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();
    }

    public List<TeamModel> GetTeam_all()
    {
        return GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModels();
    }

    public List<TournamentModel> GetTournament_All()
    {
        return GlobalConfig.TournamentFile.FullFilePath().LoadFile().ConvertToTournamentModels();
    }

    public void UpdateMatchup(MatchupModel model)
    {
        model.UpdateMatchupToFile();
    }
}
