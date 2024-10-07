namespace BarberShop.Web.Core
{
    public class Response<T>
    {
<<<<<<< HEAD

        public bool IsSucces { get; set; }
        public string Message { get; set; }
        public List<string> Errors{ get; set; }

=======
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public List<string> Errors { get; set; }
>>>>>>> a41a47080a74ab7afd1457f9ad35400e517e3ca5
        public T Result { get; set; }
    }
}
