namespace Poll_MVC.Domain.Responses.Items
{
    public class OptionResponse
    {
        public OptionResponse(int option_id, string option_description)
        {
            Option_id = option_id;
            Option_description = option_description;
        }

        public int Option_id { get; private set; }
        public string Option_description { get; private set; }
    }
}
