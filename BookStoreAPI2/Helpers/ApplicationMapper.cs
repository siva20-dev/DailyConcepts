using AutoMapper;
using BookStoreAPI2.Models;
using BookStoreAPI2.Data;

namespace BookStoreAPI2.Helpers
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            CreateMap<Books,BookModel>().ReverseMap();
        }
    }
}
