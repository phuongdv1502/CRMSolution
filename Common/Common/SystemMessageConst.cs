using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Common
{
    public static class SystemMessageConst
    {
        public const string RemoveOFFOK = "Kích hoạt dịch vụ thành công";
        public const string OffCusSuccess = "Off gói dịch vụ thành công";
        public const string Bill_Note_Existed = "Gói dịch vụ đã tồn tại ghi chú này";
        public const string Note_Cus_Existed = "Khách hàng đã tồn tại ghi chú này";
        public const string RemoveSuccess = "Xóa thành công";
        public const string ErrorData = "Lỗi thao tác";
        public const string SavingSucess = "Bảo lưu thành công";
        public const string CancessSavingSucess = "Hủy bảo lưu thành công";
        public const string ValueTypeOrOrderExisted = "Type hoặc Order đã tồn tại";
        public const string ValueParameterExisted = "Gía trị tham số đã tồn tại ";
        public const string NameDisplayParammeterExisted = "Tên hiển thị của tham số đã tồn tại";

        public const string ProductNotExisted = "Sản phẩm không tồn tại hoặc không có liệu trình";

        public const string NameTherapyExisted = "Tên liệu trình đã tồn tại";
        public const string NumberTherapyExisted = "Số lần liệu trình đã tồn tại";

        public const string CancesEquipment = "Loại bỏ thiết bị khỏi liệu trình thành công";
        public const string AddEquipment = "Thêm thiết bị vào liệu trình thành công";
        public const string NameTickchExisted = "Tiêu đề đã tồn tại";
        public const string NameBrandchExisted = "Tên chi nhánh đã tồn tại";
        public const string CodeBrandchExisted = "Mã chi nhánh đã tồn tại";

        public const string NameRoomExisted = "Tên phòng đã tồn tại";
        public const string CodeRoomExisted = "Mã phòng đã tồn tại";

        public const string AmountExisted = "Số tiền không hợp lệ";
        public const string NameCarExisted = "Tên thẻ đã tồn tại";
        public const string NotRoleCreate = "Không có quyền thêm mới";
        public const string NotRoleDelete = "Không có quyền xóa";
        public const string NotRoleExport = "Không có quyền export";
        public const string NotRoleUpdate = "Không có quyền cập nhật thông tin";

        public const string IncorrectCodeActive = "Nhập sai code active";
        public const string IncorrectCodeActiveEn = "Incorrect code active";
        public const string CreateAccountSuccess = "Tạo tài khoản thành công";
        public const string CreateAccountSuccessEn = "Create account successfull";
        public const string AddSuccess = "Thêm mới bản ghi thành công";
        public const string AddError = "Thêm mới bản ghi thất bại";
        public const string AddSuccessEn = "Add successfull";
        public const string BuySuccess = "Thanh toán thành công";
        public const string BuySuccessEn = "Check out successfull";
        public const string SaveSuccess = "Cập nhật thành công";
        public const string SaveSuccessEn = "Update successful";
        public const string IsNotExist = "Dữ liệu không tồn tại";
        public const string IsNotExistEn = "This Data is not existed!";
        public const string EmailIsExisted = "Email đã tồn tại";
        public const string EmailIsExistedEn = "Email is existed";
        public const string PhoneIsExisted = "Số điện thoại đã tồn tại";
        public const string PhoneIsExistedEn = "Phone is existed";
        public const string EmailIsNotExist = "Email không tồn tại";
        public const string EmailIsNotExistEn = "Email is not existed";
        public const string EmailAndPhoneIsExisted = "Email hoặc số điện thoại này đã được đăng ký";
        public const string EmailAndPhoneIsExistedEn = "Email or phone is existed";
        public const string EditSuccess = "Cập nhật thành công";
        public const string ResetCLSOK = "Reset cls thành công";
        public const string ChoseDateReturn = "Chọn lịch hẹn đến return thành công";
        public const string errorLoyalty = "Cộng điểm loyalty bị lỗi";

        public const string CSMAcceptReturn = "Đồng ý Return thành công";
        public const string CSMCancesReturn = "Từ chối return thành công";

        public const string ReturnSuccess = "Xử lý return thành công";

        public const string BackCSM = "Xử lý return thành công - trả KH về CSM";

        public const string FreeRoomOK = "Giải phóng phòng thành công";
        public const string FreeCSOK = "Giải phóng CS thành công";
        public const string EditFail = "Cập nhật thất bại";
        public const string ConfirmDonateBirthOK = "Xác nhận tặng quà khách hàng thành công";

        public const string ResetCheckInOK = "Reset checkin thành công";
        public const string ResetCheckInFail = "Reset checkin thất bại";
        public const string ResetCheckInOut = "Reset check out thành công, khách hàng quay lại màn hình checkin";
        public const string ResetCheckOutFail = "Reset check out thất bại";
        public const string SucessBoQuaKhamBS = "Xác nhận bỏ qua khám thành công";
        public const string DellOK = "Xóa phiếu kiểm tra thành công";

        public const string ErrorAcceptSuccessAppp = "Bạn chưa tạo phiếu liệu trình nên không thể hoàn tất tại đây";
        public const string EditSuccessEn = "Update successfull";
        public const string CheckInSuccess = "Check in thành công";
        public const string CheckInFail = "Check in thất bại";
        public const string CheckoutSuccess = "Check out thành công";
        public const string CheckoutFail = "Check out thất bại ";
        public const string ConfirmAfterDelete = "Bạn có chắc chắn muốn xóa !";
        public const string DeleteSuccess = "Xóa thành công";
        public const string DataIsEmpty = "Chưa có dữ liệu";
        public const string WereAreSendMailConfirm = "Đăng ký tài khoản thành công,Mời bạn kiểm tra hòm thư để xác nhận mail";
        public const string SendMailActive = "Mail kích hoạt đã được gửi";
        public const string SendMailActiveEn = "This mail confirm has been send to your mail";
        public const string SendMailForgotPassword = "Mail lấy lại mật khẩu đã được gửi";
        public const string SendMailForgotPasswordEn = "Mail forgotpassword has been send";
        public const string MustCheckAgree = "Bạn chưa chọn đồng ý";
        public const string MustCheckAgreeEn = "You must be check agree";
        public const string EmailConfirmSuccessFull = "Xác nhận email thành công";
        public const string EmailConfirmUnSuccessFull = "Xác nhận email thất bại";
        public const string EmailConfirmIsNotCorrect = "Xác nhận email không chính xác";
        public const string EmailConfirmIsNotCorrectEn = "Email confirm is not correct";
        public const string DateTimeIsNotCorrectFormat = "Sai định dạng ngày tháng";
        public const string ConfirmPasswordNotCorrect = "Xác nhận mật khẩu không chính xác";
        public const string ConfirmPasswordNotCorrectEn = "Confirm password is not correct !";
        public const string OldPasswordNotCorrect = "Mật khẩu cũ không chính xác";
        public const string OldPasswordNotCorrectEn = "Old password is not correct";
        public const string SendSuccess = "Gửi thành công";
        public const string SendSuccessEn = "Send Success";
        public const string StatusHide = "Hide";
        public const string StatusShow = "Show";
        public const string AccountNotExist = "Tài khoảng không tồn tại";
        public const string AccountNotExistEn = "This Account is not exist !";
        public const string PasswordNotCorrect = "Mật khẩu không chính xác";
        public const string NotRole = "Tài khoản chưa được gán quyền";
        public const string PasswordNotCorrectEn = "Your password is not correct !";
        public const string City = "thành phố";
        public const string CityEn = "thành phố";
        public const string Phone = "số điện thoại";
        public const string PhoneEn = "phone";
        public const string Address = "địa chỉ";
        public const string AddressEn = "address";
        public const string Address2 = "địa chỉ 2";
        public const string Address2En = "address2";
        public const string Fullname = "họ và tên";
        public const string FullnameEn = "Fullname";
        public const string MessageEn = "Message";
        public const string Message = "Nội dung tin nhắn";
        public const string DefaultImage = "/Content/dist/img/default-image.gif";
        public const string NoData = "Không có dữ liệu";
        public const string NoDataEn = "No Data";
        public const string CartEmpty = "Giỏ hàng trống !";
        public const string CartEmptyEn = "Your cart is empty !";
        public const string CaptchaIncorrect = "Nhập lại captcha";
        public const string CaptchaIncorrectEn = "Incorrect captcha";
        public const string ArticleExisted = "Mã sản phẩm đã tồn tại";
        public const string PhoneConfirmMes = "Một tin nhắn chứa mã xác nhận đã được gửi đến số của bạn , hãy nhập mã xác nhận đó để hoàn tất đăng ký !";
        public const string PhoneConfirmMesEn = "A message containing a confirmation code has been sent to your number, please enter the confirmation code to complete the registration !";
        public const string BataMessageActiveCode = "Ban dung ma so sau day de hoan tat dang ky : ";
        public const string Notification = "Thông báo";
        public const string NotificationEn = "Notification";
        public const string SearchContentFormat = "Từ khóa không đúng định dạng !";
        public const string SearchContentFormatEn = "This content is not correct format !";
        public const string DataExisted = "Dữ liệu đã tồn tại";
        public const string RoomUsing = "Phòng đang sử dụng trị liệu không thể khóa";
        public const string NotUpdateRoom = "Phòng đang sử dụng trị liệu không thể cập nhật thông tin";
        public const string DataNotExisted = "Dữ liệu không tồn tại";
        public const string DateSmallNow = "Chỉ có thể cập nhật,xóa,thêm mới dữ liệu >= ngày hiện tại";
        public const string DateNotCorect = "Ngày thiết lập không xác định";
        public const string UpdateSuccess = "Cập nhật dữ liệu thành công";
        public const string UpdateError = "Cập nhật dữ liệu thất bại";
        public const string QuantityNotNumber = "Số lượng phải là dạng số và lớn hơn 0";
        public const string KTAccept = "Kế toán đang xử lý";
        public const string CSMAccept = "CSM đang xử lý";


        public const string RoleIsNotExist = "Quyền không tồn tại";
        public const string MenuIsNotExist = "Menu không tồn tại";
        public const string TickIsNotExist = "Tick không tồn tại";

        public const string AccountIsNotExist = "Tài khoản không tồn tại hoặc đã bị khóa";
        public const string RoleAndAccountExit = "Tài khoản đã tồn tại quyền này";
        public const string RoleAndAccountandMenuExit = "Tài khoản đã tồn tại quyền với menu này";
        public const string RoleMenuExit = "Quyền đã tồn tại menu này";
        public const string RoleTickExit = "Quyền đã tồn tại Tick này";
        public const string MsgChoseRole = "Mời bạn chọn quyền";

        public const string AccountIsnotRoleExit = "Tài khoản chưa có quyền này";
        public const string ConfirmProcess = "Tiến hành thực hiện dịch vụ với khách hàng ";
        public const string ConfirmProcess1 = " ...";
        public const string ChoseCustomerSuccess = "Chọn khách hàng xử lý thành công";
        public const string ChoseCustomerNotSuccess = "Chọn khách hàng xử lý thất bại";
        public const string CancesProcessCustomer = "Hủy thực hiện dịch vụ với khách hàng  ";
        public const string KHBoQuaKham = "Xác nhận khách hàng ";
        public const string KHBoQuaKham1 = " bỏ qua khám... !";
        public const string CancesProcessCustomer1 = "....";

        public const string CancesProcessSuccess = "Hủy xử lý khách hàng thành công";
        public const string CancesProcessIsnotSuccess = "Hủy xử lý khách hàng không thành công";
        public const string lstAccountIsnotNull = "Chưa chọn tài khoản cần thêm quyền";
        public const string lstMenuIsnotNull = "Chưa chọn menu thêm vào quyền cho tài khoản";
        public const string RoleIsInvailMenu = "Quyền đã tồn tại menu";
        public const string RoleIsVailAcount = "Tài khoản đã có quyền quản lý menu";

        public const string MachineIsNotExisted = "Thiết bị không tồn tại hoặc chi nhánh chưa có loại thiết bị này";

        public const string ShiftIsNotExisted = "Ca không tồn tại";
        public const string ReportExisted = "Liệu trình đã có phiếu test";
        public const string BrandIsNotExist = "Chi nhánh không tồn tại";
        public const string LstShiftNotExit = "Chưa chọn ca làm việc";
        public const string DateShiftExit = "Ngày đã có lịch làm việc";
        public const string DateEquipmentExit = "Ngày đã thiết lập vật tư";

        public const string ConfirmLockCard = "Bạn có chắc chắn muốn khóa loại thẻ này không ?";
        public const string ConfirmUnLockCard = "Bạn có chắc chắn muốn mở khóa loại thẻ này không ?";

        public const string ConfirmLockRoom = "Bạn có chắc chắn muốn khóa phòng này không ?";
        public const string ConfirmUnLockRoom = "Bạn có chắc chắn muốn mở khóa phòng này không ?";

        public const string ConfirmLockBrandch = "Bạn có chắc chắn muốn khóa chi nhánh này không ?";
        public const string ConfirmUnLockBrandch = "Bạn có chắc chắn muốn mở khóa chi nhánh này không ?";

        public const string ConfirmLockParameter = "Bạn có chắc chắn muốn khóa tham số này không ?";
        public const string ConfirmUnLockParameter = "Bạn có chắc chắn muốn mở khóa tham số này không ?";


        public const string ConfirmLockTick = "Bạn có chắc chắn muốn khóa tiêu đề này không ?";
        public const string ConfirmUnLockTick = "Bạn có chắc chắn muốn mở khóa tiêu đề này không ?";
    }
}
