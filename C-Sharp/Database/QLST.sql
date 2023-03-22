create database SuperMarket_Management_DB;

go

use SuperMarket_Management_DB;

go

--
-- bảng "Nhân Viên", (Số lượng nhân viên tối đa: 99)
--

create table Staff
(
	Id int identity,
	StaffId as 'ST' + right('0' + convert(varchar(2), id), 2) persisted,
	StaffName nvarchar(100) not null,
	Gender nvarchar(4) not null,
	Birthday date not null,
	NumberPhone varchar(15) not null,
	AddressNow nvarchar(200) not null,
	Position nvarchar(50) not null,
	StatusItem bit not null
	primary key (StaffId),
	check (Gender in (N'Nam', N'Nữ', N'Khác'))
)

--
-- bảng "Nhóm Hàng" (Số lượng nhóm hàng hóa tối đa: 99)
--

create table Category
(
	Id int identity,
	CategoryId as 'CA' + right('0' + cast(Id as varchar(2)), 2) persisted,
	CategoryName nvarchar(100) not null,
	StatusItem bit not null,
	primary key (CategoryId)
)

--
-- bảng "Hàng Hóa", (Số lượng hàng hóa tối đa: 9,999)
--

create table Product	
(
	Id int identity,
	ProductId as 'PR' + right('000' + cast(Id as varchar(4)), 4) persisted,
	ProductImg image,
	ProductName nvarchar(100) not null,
	ImportPrice money not null,
	PriceToSell money not null,
	Unit nvarchar(20) not null,
	Quantity integer not null,
	StatusItem bit not null,
	CategoryId varchar(4),
	primary key (ProductId),
)

--
-- bảng "Hóa Đơn" (Số bill tối đa: 99,999,999; Trung bình gần 2,740 bill/ngày, sử dụng 100 năm nếu không có nhu cầu mở rộng chi nhánh)
--

create table Bill
(
	Id int identity,
	BillId as 'BI' + right('0000000' + convert(varchar(8), Id), 8) persisted,
	BillDate date not null,
	Discount money,
	Total money not null,
	StaffId varchar(4) not null,
	CustomerId varchar(9),
	primary key (BillId)
)

--
-- bảng "Chi Tiết Hóa Đơn"
--

create table BillDetail
(
	BillId varchar(10) not null,
	ProductId varchar(6) not null,
	Quantity integer not null
	primary key (BillId, ProductId)
)

--
-- bảng "Tài Khoản"
--

create table LoginAccount
(	
	Username varchar(15) not null,
	LoginPassword varchar(15) not null,
	StaffId varchar(4) not null,
	Permission integer not null,
	StatusItem bit not null
	primary key (Username)
)

--
-- bảng "Khách Hàng" (Số khách hàng tối đa: 9,999,999; Dựa vào dân số trung bình của thành phố hồ chí minh hiện nay là hơn 9,000,000 triệu dân và sẽ còn tăng)
--

create table Customer
(
	Id int identity,
	CustomerId as 'CU' + right('000000' + cast(Id as varchar(7)), 7) persisted,
	CustomerName nvarchar(100) not null,
	Gender nvarchar(4) not null,
	NumberPhone varchar(15) not null,
	CustomerAddress nvarchar(200),
	Point integer not null,
	StatusItem bit not null,
	primary key (CustomerId),
	check (Gender in (N'Nam', N'Nữ', N'Khác'))
)

--
-- bảng "Nhà Cung Cấp" (Số lượng nhà cung cấp tối đa: 9,999)
--

create table Supplier
(
	Id int identity,
	SupplierId as 'SU' + right('000' + convert(varchar(4), Id), 4) persisted,
	SupplierName nvarchar(100) not null,
	SupplierAddress nvarchar(200) not null,
	NumberPhone varchar(15) not null, 
	StatusItem bit not null,
	primary key (SupplierId)
)

--
-- bảng "Phiếu Nhập" (Số phiếu nhập hàng tối đa: 9,999; Trung bình mỗi tháng nhập hàng 4 lần)
--

create table InventoryReceivingVoucher
(
	Id int identity,
	Re_Id as 'RE' + right('000' + cast(Id as varchar(4)), 4) persisted,
	Re_Date date not null,
	Total money not null,
	StaffId varchar(4) not null,
	SupplierId varchar(6) not null,
	primary key (Re_Id)
)

--
-- bảng "Chi Tiết Phiếu Nhập"
--

create table InventoryReceivingVoucherDetail
(
	Re_Id varchar(6) not null,
	ProductId varchar(6) not null,
	Re_Price money not null,
	Quantity integer not null,
	primary key (Re_Id, ProductId)
)

--
-- bảng "Phiếu Chi" (Số phiếu chi tối đa: 9,999)
--

create table PaymentVoucher
(
	Id int identity,
	Pay_Id as 'PA' + right('000' + cast(Id as varchar(4)), 4) persisted,
	Pay_Date date not null,
	Reason nvarchar(500) not null,
	Note nvarchar(500),
	Pay_Money money not null,
	StaffId varchar(4) not null,
	Re_Id varchar(6) not null,
	primary key (Pay_Id)
)

--
-- Khóa
--

--
-- Khóa ngoại cho bảng Hàng Hóa
--

alter table Product
	add constraint FkProduct_CategoryId foreign key (CategoryId) references Category (CategoryId);

--
-- Khóa ngoại cho bảng Tài Khoản
--

alter table LoginAccount
	add constraint FkLoginAccount_StaffId foreign key (StaffId) references Staff (StaffId);

--
-- Khóa ngoại cho bảng Hóa Đơn
--

alter table Bill
	add constraint FkBill_CustomerId foreign key (CustomerId) references Customer (CustomerId);
alter table Bill
	add constraint FkBill_StaffId foreign key (StaffId) references Staff (StaffId);

--
-- Khóa ngoại cho bảng Chi Tiết Hóa Đơn
--

alter table BillDetail
	add constraint FkBillDetail_BillId foreign key (BillId) references Bill (BillId);
alter table BillDetail
	add constraint FkBillDetail_ProductId foreign key (ProductId) references Product (ProductId);

--
-- Khóa ngoại cho bảng Phiếu Nhập
--

alter table InventoryReceivingVoucher
	add constraint FkInventoryReceivingVoucher_StaffId foreign key (StaffId) references Staff (StaffId);
alter table InventoryReceivingVoucher
	add constraint FkInventoryReceivingVoucher_SupplierId foreign key (SupplierId) references Supplier (SupplierId);

--
-- Khóa ngoại cho bảng Chi Tiết phiếu nhập
--

alter table InventoryReceivingVoucherDetail
	add constraint FkInventoryReceivingVoucherDetail_Re_Id foreign key (Re_Id) references InventoryReceivingVoucher (Re_Id);
alter table InventoryReceivingVoucherDetail
	add constraint FkInventoryReceivingVoucherDetail_ProductId foreign key (ProductId) references Product (ProductId);

--
-- Khóa ngoại cho bảng Phiếu Chi
--

alter table PaymentVoucher
	add constraint FkPaymentVoucher_StaffId foreign key (StaffId ) references Staff (StaffId );
alter table PaymentVoucher
	add constraint FkPaymentVoucher_Re_Id foreign key (Re_Id) references InventoryReceivingVoucher (Re_Id);

--
--	Data
--

--
--	Data For Category Table
--

insert into Category(CategoryName, StatusItem) Values
					(N'Gia vị', 1),
					(N'Bánh kẹo', 1),
					(N'Nước uống giải khát', 1),
					(N'Thực phẩm khô', 1);

					DBCC CHECKIDENT ('Category', RESEED, 0);
					select * from Category
					insert into Category(CategoryName, StatusItem) values (N'Thực phẩm tươi', 0)
					delete from Category where CategoryId = 'CA14' or CategoryId = 'CA05' or CategoryId= 'CA07';select CategoryId, CategoryName, StatusItem from Category
					--update Category set CategoryName = N'ádas', StatusItem = 0 where CategoryId = 'CA06'
--
--	Data For Product Table
--

insert into Product (ProductName,ImportPrice, PriceToSell, Unit, Quantity, StatusItem, CategoryId) Values
					(N'Dầu đậu nành Tường An 1L',50400,63000,N'Chai',42,1,'CA01'),
					(N'Dầu ăn dinh dưỡng cho bé Kiddy 250ml',41600,52100,N'Chai',25,1,'CA01'),
					(N'Dầu ôliu Extra Virgin Tường An 250ml',64800,81000,N'Chai',20,1,'CA01'),
					(N'Nước mắm Nam Ngư 750ml',35200,44000,N'Chai',48,1,'CA01'),
					(N'Đường Organic Biên Hòa 800g',68400,85600,N'Hộp',36,1,'CA01'),
					(N'Nước tương đậm đặc Maggi 300ml',14500,18200,N'Chai',40,1,'CA01'),
					(N'Hạt nêm thịt thăn, xương ống, tủy Knorr 900g',64500,80700,N'Gói',80,1,'CA01'),
					(N'Tương ớt Cholimex chai 270g',9600,12100,N'Chai',70,1,'CA01'),
					(N'Tương cà Chin-su chai eo 250g',11200,14000,N'Chai',60,1,'CA01'),
					(N'Bột ngọt Vedan gói 1kg',49600,62000,N'Gói',55,1,'CA01'),
					-- Bánh kẹo
					(N'Bánh choco-Pie Orion hộp 396g',42700,53400,N'Hộp',55,1,'CA02'),
					(N'Bánh trứng Tipo Hữu Nghị gói 220g',34500,43200,N'Gói',50,1,'CA02'),
					(N'Mực tẩm gia vị Thái Bento gói 24g',18400,23000,N'Gói',49,1,'CA02'),
					(N'Bánh quy nhân kem vani Oreo gói 137g',42700,53400,N'Cái',40,1,'CA02'),
					(N'Bánh que Yan Yan socola 50g',19200,24000,N'Cái',77,1,'CA02'),
					(N'Bánh snack vị kim chi Hàn Quốc OStar gói 90g',42400,53000,N'Gói',67,1,'CA02'),
					(N'Kẹo dẻo Cola Chupa Chups gói 90g',18100,22700,N'Gói',55,1,'CA02'),
					(N'Đậu phộng da cá Tân Tân gói 285g',35200,44000,N'Gói',60,1,'CA02'),
					(N'Sô cô la KitKat Chunky gói 38g',12000,15000,N'Cái',55,1,'CA02'),
					(N'Socola Sữa M&M gói 40g/37g',15600,19500,N'Gói',60,1,'CA02'),
					-- Nước uống giải khát
					(N'Nước cam ép Vfresh Vinamilk hộp 1L',35200,44000,N'Hộp',32,1,'CA03'),
					(N'Nước uống đóng chai Aquafina 1,5L',8800,11000,N'Chai',20,1,'CA03'),
					(N'Nước uống Isotonic 7 Up Revive 500ml',8900,11200,N'Hộp',46,1,'CA03'),
					(N'Trà sữa Latte Kirin chai 345ml',7500,9400,N'Chai',70,1,'CA03'),
					(N'Nước yến sào cao cấp lọ 70ml',30600,38300,N'Lọ',29,1,'CA03'),
					(N'Nước giải khát Coca Cola chai 390ml',5900,7400,N'Chai',90,1,'CA03'),
					(N'Nước uống ion Pocari 350ml',8600,10800,N'Hộp',70,1,'CA03'),
					(N'Cà phê Việt đen đá NESCAFE hộp 240g',43200,54000,N'Hộp',20,1,'CA03'),
					(N'Trà hương đào Dilmah hộp 30g',25200,31600,N'Hộp',40,1,'CA03'),
					(N'Cà phê sữa đá Highlands Coffee 235ml',10800,13600,N'Lon',43,1,'CA03'),
					-- Thực phẩm khô
					(N'Gạo ST25 giống cây trồng TW túi 3kg',79900,99900,N'Gói',15,1,'CA04'),
					(N'Nấm hương Donavi 50g',24800,31000,N'Gói',27,1,'CA04'),
					(N'Gạo Lứt Đồ Simply 1kg',53200,66600,N'Gói',31,1,'CA04'),
					(N'Mật ong Viethoney chai 300g',37600,47000,N'Chai',38,1,'CA04'),
					(N'Ngũ cốc Milo Nestlé Hộp 330g',74200,92800,N'Gói',13,1,'CA04'),
					(N'Bơ thực vật Tường An hộp 80g',7500,9400,N'Hộp',32,1,'CA04'),
					(N'Pate thịt heo Vissan hộp 170g',24300,30400,N'Hộp',62,1,'CA04'),
					(N'Cá nục sốt cà Sea Crown lon 155g',13500,16900,N'Lon',57,1,'CA04'),
					(N'Bột chiên xù Miwon gói 100g',9300,11700,N'Gói',71,1,'CA04'),
					(N'Bột mì đa dụng Meizan gói 500g',11100,13900,N'Gói',64,1,'CA04');
--
--	Data For Staff Table
--

insert into Staff(StaffName, Gender, Birthday, NumberPhone, AddressNow, Position, StatusItem) Values
				(N'Võ Quang Đăng Khoa',N'Nam','2002-03-21','0702788634',N'230 Nguyễn Thị Định, Quận 2',N'Quản lý',1),
				(N'Võ Văn Hùng','Nam','2002-07-15','0327794829',N'273 An Dương Vương, Quận 5',N'Nhân viên bán hàng',1),
				(N'Thiều Việt Hoàng',N'Nam','2002-03-01','0490299446',N'87 Ngô Quyền, Quận 5',N'Nhân viên kho',1),
				(N'Nguyễn Nhật Huy',N'Khác','2002-11-18','0635843398',N'476 3 tháng 2, Quận 10',N'Nhân viên bán hàng',1),
				(N'Phùng Tùng Uy',N'Nam','2002-09-05','0394751283',N'108 Tây Thạnh, Tân Phú',N'Nhân viên kho',1);

--
--	Data For LoginAccount Table
--

insert into LoginAccount(Username, LoginPassword, StaffId, Permission, StatusItem) Values
						('dangkhoa','sadboidoncoi','ST01',0,1),
						('hungtadasuke','deptraico102','ST02',1,1),
						('thhoang','skythhoang','ST03',2,1),
						('huycc','iamfoolish','ST04',1,1),
						('tunguy','uy123','ST05',2,1);
						select * from LoginAccount
						delete LoginAccount where StaffId = 'ST09'
						insert into LoginAccount(Username, LoginPassword, StaffId, Permission, StatusItem) Values
						('1234','123','ST07',0,1)
--
--	Data For Customer Table
--

insert into Customer(CustomerName, Gender, NumberPhone, CustomerAddress, Point, StatusItem) Values
					(N'Phạm Anh Tuấn',N'Nam','0839201593',N'10 Trần Nhật Duật, Quận 1',10, 1),
					(N'Nguyễn Thị Hồng Hạnh',N'Nữ','0838990635',N'483/22 Lê Văn Sỹ, quận 3',41, 1),
					(N'Nguyễn Thị My',N'Nữ','0438210035',N'49 Đồng Khởi, Quận 1',26, 1),
					(N'Trương Thanh Dũng',N'Nam','0822148840',N'74/3 Hai Bà Trưng, Quận 1',389, 1),
					(N'Nguyễn Đăng Khoa',N'Nam','0838489670',N'188/4 Võ Văn Tần, quận 3',85, 1),
					(N'Nguyễn Thị Cẩm Duyên',N'Nữ','0437345618',N'678 Trường Chinh, Tân Bình',311, 1),
					(N'Trần Văn Hi',N'Nam','0373952297',N'298 Nguyễn Trọng Tuyển, Phú Nhuận',47, 1),
					(N'Nguyễn Hải Âu',N'Nam','0613847295',N'701 Lê Hồng Phong, Quận 10',45, 1),
					(N'Lê Hồng Hoa',N'Nữ','0838364315',N'89 Nguyễn Công Trứ, Quận 1',153, 1),
					(N'Nguyễn Hữu An',N'Nam','0838230814',N'129 Khánh Hội, Quận 4',70, 1);
--
--	Data For Supplier Table
--

insert into Supplier(SupplierName, SupplierAddress, NumberPhone, StatusItem) Values
					(N'Unilever',N'156 Nguyễn Lương Bằng, Quận 7','0838356312',1),
					(N'Calofic',N'235 Nguyễn Văn Cừ, Quận 1','0438516896',1),
					(N'Vinamilk',N'10 Tân Trào, Quận 7','0838921723',1),
					(N'Phú Thái (P&G)',N'374A/1 Đường Lê Văn Quới, Tân Bình','0773848886',1),
					(N'iWater',N'48 Nguyễn Thị Huỳnh, Phú Nhuận','0383844745',1);

--
-- Stored Procedure
--

--
-- Stored Procedure Product
--

--
-- Procedure getProductList
--
go

create procedure getProductList
as
begin
	select C.CategoryName, P.ProductId,  P.ProductName, P.Unit, P.ImportPrice, P.PriceToSell, P.Quantity, P.ProductImg, P.StatusItem from Product as P, Category as C where P.CategoryId = C.CategoryId; 
end

--
-- Procedure insertProduct
--

go

create procedure insertProduct @ProductImg image, @ProductName nvarchar(100), @ImportPrice money, @PriceToSell money, @Unit nvarchar(20), @Quantity int, @StatusItem bit, @CategoryId varchar(4)
as
begin
	insert into Product values (@ProductImg, @ProductName, @ImportPrice, @PriceToSell, @Unit, @Quantity, @StatusItem, @CategoryId);
end

--
-- Procedure updateProduct
--

go

create procedure updateProduct @ProductImg image, @ProductName nvarchar(100), @ImportPrice money, @PriceToSell money, @Unit nvarchar(20), @Quantity int, @StatusItem bit, @CategoryId varchar(4), @ProductId varchar(6)
as
begin
	update Product set ProductName = @ProductName, ProductImg = @ProductImg, ImportPrice = @ImportPrice, PriceToSell = @PriceToSell, Unit = @Unit, Quantity = @Quantity, StatusItem = @StatusItem, CategoryId = @CategoryId where ProductId = @ProductId;
end

--
-- Trigger update product quantity when a detailBill is inserted.
--

go

create or alter trigger trg_updateProductQuantiy on BillDetail after insert
as
begin
	update Product 
	set Quantity = Quantity - (select I.Quantity from Inserted as I)
	where ProductId = (select I.ProductId from Inserted as I);
end

--
-- Query area
--

select * from Category;
select * from Product;
select * from Customer;
select * from LoginAccount;
select * from Staff;
select * from Supplier;
select * from Bill;
select * from BillDetail;
select * from InventoryReceivingVoucher;
select * from InventoryReceivingVoucherDetail;
select * from PaymentVoucher;

DBCC checkident(Bill, reseed, 1);
DBCC checkident(Product, reseed, 46);

insert BillDetail values ('BI00000001', 'PR0025', 2, 41600);


