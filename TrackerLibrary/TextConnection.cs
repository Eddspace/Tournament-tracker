namespace TrackerLibrary;

public class TextConnection : IDataConnection
{

    // TODO - Make the CreatePrize method actually save to text files
    public PrizeModel CreatePrize(PrizeModel model)
    {
        model.Id = 1;
        return model;
    }
}
