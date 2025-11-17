namespace TrackerLibrary;

public class SqlConnector : IDataConnection
{

    // TODO - Make the CreatePrize method actually save to the database
    public PrizeModel CreatePrize(PrizeModel model)
    {
        model.Id = 1;
        return model;
    }
}
