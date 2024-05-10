using TaskManager.Dto;
using TaskManager.Entity.Foundation;

namespace TaskManager.Profile;

public class MappingProfile : AutoMapper.Profile
{
    public MappingProfile()
    {
        CreateMap<BranchDto, Branch>().ReverseMap();
    }
}