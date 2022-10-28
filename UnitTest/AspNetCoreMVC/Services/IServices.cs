using AspNetCoreMVC.DataAccess;
namespace AspNetCoreMVC.Services
{
    public interface IServices
    {
        List<MemberViewModel> GetListMember();
        Member GetOneMember(int index);
        void AddMember(CreateMemberRequest request);
        List<EditMemberViewModel> GetListEdit();
        void UpdateMember(int index, EditMemberViewModel model);
        void DeleteMember(int index);
    }
}