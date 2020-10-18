namespace Poll_MVC.Domain.Responses.Items
{
    public class VotesResponse
    {
        public VotesResponse(int option_id, int qty)
        {
            Option_id = option_id;
            Qty = qty;
        }

        public int Option_id { get; private set; }
        public int Qty { get; private set; }
    }
}
