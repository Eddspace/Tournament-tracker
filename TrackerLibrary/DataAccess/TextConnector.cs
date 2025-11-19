using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;

namespace TrackerLibrary.DataAccess;

public class TextConnector : IDataConnection
{
    private const string PrizesFile = "PrizeModels.csv";

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
}
