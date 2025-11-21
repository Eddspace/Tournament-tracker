using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess;

public interface IDataConnection
{
    PrizeModel CreatePrize(PrizeModel model);
    PersonModel CreatePerson(PersonModel model);
    TeamModel CreateTeam(TeamModel model);

    List<PersonModel> GetPerson_all();
    List<TeamModel> GetTeam_all();
}
