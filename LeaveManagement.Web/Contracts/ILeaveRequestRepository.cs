using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;

namespace LeaveManagement.Web.Contracts
{
    public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
    {
        Task<bool> CreateLeaveRequest(LeaveRequestCreateVM model);
        Task<EmployeeLeaveRequestViewVM> GetMyLeaveDetails();

        Task<List<LeaveRequest>> GetAllAsync(string employeeId);

        Task ChangeApprovalStatus(int leaveRequestId, bool approved);

        Task<AdminLeaveRequestViewVM> GetAdminLeaveRequestList();

        Task<LeaveRequestVM?> GetLeaveRequestAsync(int? id);

        Task CancelLeaveRequest(int leaveRequestId); 
    }
}
  