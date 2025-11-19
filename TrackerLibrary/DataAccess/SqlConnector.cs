using Dapper;
using System.Data;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess;

	//@PlaceNumber int,
	//@PlaceName nvarchar(50),
	//@PrizeAmount money,
    //@PrizePercentage float,
	//@Id int = 0 output

public class SqlConnector : IDataConnection
{

    // TODO - Make the CreatePrize method actually save to the database
    public PrizeModel CreatePrize(PrizeModel model)
    {
        using (IDbConnection connection = new Microsoft.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments")))
        {
            var p = new DynamicParameters();
            p.Add("@PlaceNumber", model.PlaceNumber);
            p.Add("@PlaceName", model.PlaceName);
            p.Add("@PrizeAmount", model.PrizeAmount);
            p.Add("@PrizePercentage", model.PrizePercentage);
            p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

            connection.Execute("dbo.spPrizes_Insert", p, commandType: CommandType.StoredProcedure);

            model.Id = p.Get<int>("@Id");

            return model;
        }
    }
}
