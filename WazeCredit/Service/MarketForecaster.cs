using WazeCredit.Models;

namespace WazeCredit.Service
{
    public class MarketForecaster : IMarketForecaster
    {
        public MarketResult GetMarketPrediction()
        {
            //call API to do some complex calculations and current stock market forecast
            //For course purpose we will hard code the result
            return new MarketResult
            {
                MarketCondition = MarketCondition.StableUp
            };
        }
    }

}
