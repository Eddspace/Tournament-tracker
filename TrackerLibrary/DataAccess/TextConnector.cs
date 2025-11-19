using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess;

public class TextConnector : IDataConnection
{

    // TODO - Make the CreatePrize method actually save to text files
    public PrizeModel CreatePrize(PrizeModel model)
    {
        model.Id = 1;
        return model;
    }
}
