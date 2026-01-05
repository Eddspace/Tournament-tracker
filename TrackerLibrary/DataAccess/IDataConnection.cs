using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess;

public interface IDataConnection
{
    void CreatePrize(PrizeModel model);
    void CreatePerson(PersonModel model);
    void CreateTeam(TeamModel model);
    void CreateTournament(TournamentModel model);
    void CompleteTournament(TournamentModel model);
    void UpdateMatchup(MatchupModel model);
    List<PersonModel> GetPerson_all();
    List<TeamModel> GetTeam_all();
    List<TournamentModel> GetTournament_All();
    
}
