
namespace OnionArcExample.Application.Parameters
{
    public class RequestParameter
    {

        //gelen requestteki parametreleri temsil edecek Parameters Object
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
        public RequestParameter(int pageSize, int pageNumner)
        {
            PageNumber = pageNumner;
            PageSize = pageSize;
        }
    }
}
