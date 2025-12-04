using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess;

public interface IDataConnection
{
    PrizeModel CreatePrize(PrizeModel model);
    PersonModel CreatePerson(PersonModel model);
    TeamModel CreateTeam(TeamModel model);
    TournamentModel CreateTournament(TournamentModel model);

    List<PersonModel> GetPerson_all();
    List<TeamModel> GetTeam_all();
    List<TournamentModel> GetTournament_All();
    void UpdateMatchup(MatchupModel model);
}
