USE QLBANHANG
GO


INSERT INTO dbo.NHANVIEN
(
    HOTEN,
    NGAYSINH,
    GT,
    SDT,
    MAIL,
    DIACHI,
    NGAYLAM
)
VALUES	(N'Phạm Nguyễn Trường An','19991102',N'nam',097556553,N'truonganh@gmail.com',N'A20-BT6 Khu Đô Thị Văn Quán-Hà Đông, Hà Nội','20180101'),
		(N'Trần Khánh An','19991202',N'nữ',0907195559,N'antran@gmail.com',N'Khu Ao Sen,Phường Mộ Lao, Hà Đông, Hà Nội','20180112'),
		(N'Võ Thành An','19990619',N'nam',0903637860,N'anhvo@gmail.com',N'21/766 La Thành, Ba Đình, Hà Nội','20180313'),
		(N'Đặng Văn Dũng','19990219',N'nam',0903637400,N'dangdung@gmail.com',N'137 Cự Lộc, Thanh Xuân, Hà Nội','20180415'),
		(N'Hoàng Thị Thanh Hương','19990321',N'nữ',0908605759,N'huongthanh@gmail.com',N'sô 60, ngõ 28 Xuân La, Tây Hồ, Hà Nội','20180502'),
		(N'Vũ Thị Thu Thủy','19980617',N'nữ',0916830853,N'thuythu@gmail.com',N'15 Hoa Lâm, Long Biên, Hà Nội','20180619'),
		(N'Dương Ngọc Anh','19980506',N'nữ',0973333069,N'ngocanh@gmail.com',N'B310, Khu B11B Nam Trung Kiên, Hà Nội','20181209'),
		(N'Nguyễn Thị Lệ Quyên','19980411',N'nữ',0988100391,N'',N'Đầm Trấu, Bạch Đằng, Hà Nội','20170915'),
		(N'Đào Văn Hùng','19990611',N'nữ',0988576555,N'daohung@gmail.com',N'số 6 A2 Xưởng Mộc, An Dương, Tây Hôi, Hà Nội','20170820'),
		(N'Nguyễn Lan Hương','19951016',N'nam',0979737395,N'nguyenlan@gmail.com',N'P.209 E4 Thanhh Xuân Bắc, Hà Nội','20171106')
GO



INSERT INTO dbo.KHACHHANG
(
    TENKH,
    NGAYSINH,
    GT,
    SDT,
    MAIL,
    DIACHI,
    NGAYDK
)
VALUES	(N'Nguyễn Văn Hưng','19990702',N'nam',0123098456,N'vanhung@gmail.com',N'số1177 Đường Láng, Đông Đa, Hà Nội','20180102'),
		(N'Bùi Thị Thu Hương','19990318',N'nữ',0123097001,N'huongthu@gmail.com',N'số 2 Đại Cồ Việt, Hai Bà Trưng, Hà Nội','20180102'),
		(N'Nguyễn Ngọc Hưởng','19990222',N'nam',0124098406,N'huongnguyen@gmail.com',N'số 159 Thái Hà, Đống Đa, Hà Nội','20180102'),
		(N'Trịnh Thế Hữu','19980101',N'nam',0125001010,N'huutrinh@gmail.com',N'số 110 Trần Phú, Hà Đông, Hà Nội','20180102'),
		(N'Nguyễn Doãn Khang','19980829',N'nam',0123098190,N'doankhang@gmail.com',N'số 18 Phạm Hùng, Nam Từ Liêm, Hà Nội','20180102'),
		(N'Đặng Quốc Khánh','19971122',N'nam',0123098456,N'quockhanh@gmail.com',N'số 175 Trường Trinh, Thanh Xuân, Hà Nội','20180102'),
		(N'Đồng Đức Khải','19970220',N'nam',0901098450,N'dongkhai@gmail.com',N'số 345 Phạm Văn Đồng, Phú Diễn, Bắc Từ Liêm, Hà Nội','20180102'),
		(N'Đinh Xuân Khiêm','19960519',N'nam',090298451,N'xuankhiem@gmail.com',N'số 210 Thái Hà, Đống Đa, Hà Nội','20180102'),
		(N'Phạm Minh Khương','19960427',N'nam',090398452,N'phamkhuong@gmail.com',N'số 2, ngõ 71, Trần Quang Diệu, Đống Đa, Hà Nội','20180102'),
		(N'Đỗ Xuân Kiên','19960916',N'nam',090498453,N'xuankien@gmail.com',N'số 30 Nguyễn Văn Huyên, Cầu Giấy','20180102'),
		(N'Bùi Hoàng Lam','19950301',N'nam',090598454,N'hoangnam@gmail.com',N'số 15 Xã Đàn, Đống Đa, Hà Nội','20180102'),
		(N'Mại Ngọc Lệ','19950930',N'nữ',090698455,N'lemai@gmail.com',N'số 152-154 Trần Duy Hưng, Cầu Giấy, Hà Nội','20180102'),
		(N'Phạm Thanh Liêm','19951012',N'nam',090798456,N'liempham@gmail.com',N'số 169 Thái Hà, Đống Đa, Hà Nội','20180102'),
		(N'Dương Quang Linh','19951101',N'nam',091690457,N'linhdung@gmail.com',N'số 63 Nguyễn Hoàng, Nam Từ Liêm, Hà Nội','20180102'),
		(N'Nguyễn Thị Loan','19950814',N'nữ',091790458,N'loannguyen@gmail.com',N'số 150 Nguyễn Văn Cừ, Long Biên, Hà Nội','20180102'),
		(N'Chu Ngọc Linh','19950916',N'nữ',091890458,N'linhchu@gmail.com',N'số 29F Hai Bà Trưng, Hoàn Kiêm, Hà Nội','20180102'),
		(N'Chu Nhất Long','19950930',N'nam',091990408,N'chulong@gmail.com',N'số 125 Trần Phú, Hà Đông, Hà Nội','20180102'),
		(N'Nguyễn Thành Lộc','19950301',N'nam',091790459,N'locnguyen@gmail.com',N'số 18 Phạm Hùng, Cầu Giấy, Hà Nội','20180102'),
		(N'Nguyễn Thị Lợi','19941120',N'nữ',098090460,N'nguyenloi@gmail.com',N'số 166 Phạm Văn Đồng, Từ Liêm, Hà Nội','20180102'),
		(N'Phạm Xuân Luân','19940306',N'nam',098190461,N'phamluan@gmail.com',N'km 11 đường 32, Bắc Từ Liêm, Hà Nội','20180102'),
		(N'Ngô Văn Lương','19940102',N'nam',0982904620,N'ngoluong@gmail.com',N'số 32 Đường Cầu Bươu, Thanh Trì, Hà Nội','20180102'),
		(N'Đinh Tấn Lực','19930705',N'nam',0983904621,N'tanluc@gmail.com',N'số 682 Quang Trung, Hà Đông, Hà Nội','20181021'),
		(N'Vũ Thị Khánh Ly','19931024',N'nữ',0984904622,N'lyvu@gmail.com',N'số 181 Nguyễn Văn Bằng, Đống Đa, Hà Nội','20180102'),
		(N'Nguyễn Đức Mạnh','19930130',N'nam',0985904623,N'nguyenmanh@gmail.com',N'số 54 Tố Hữu, Nam Từ Liêm, Hà Nội','20180102'),
		(N'Chu Nhật Minh','19931214',N'nam',0973904624,N'minhchu@gmail.com',N'số 111 Hồ Tùng Mậu, Cầu Giấy, Hà Nội','20180102'),
		(N'Bùi Thị Trà My','19931029',N'nữ',0970904625,N'buimy@gmail.com',N'số 18 Nguyễn Chí Thanh, Ba Đình, Hà Nội','20180102'),
		(N'Bùi Đình Nam','19930627',N'nam',0971904626,N'nambu@gmail.com',N'số 3 Nguyễn Văn Linh, Long Biên','20180102'),
		(N'Bùi Thị Thu Nga','19930912',N'nữ',0972904627,N'ngabui@gmail.com',N'số 72 Trường Trinh, Đống Đa, Hà Nội','20180102'),
		(N'Vũ Trọng Nghĩa','19930627',N'nam',0973904628,N'vunghia@gmail.com',N'số 399 Phạm Văn Đồng, Bắc Từ Liêm, Hà Nội','20180102'),
		(N'Lê Thị Ngọc','19920614',N'nữ',0974904629,N'lengoc@gmail.com',N'số 36 Phạm Văn Đồng, Bắc Từ Liêm, Hà Nội','20180102'),
		(N'La Văn Nguyên','19920816',N'nam',0960904630,N'nguyenla@gmail.com',N'số 549 Nguyễn Văn Cừ, Long Biên, Hà Nội','20180102'),
		(N'Phan Văn Nhật','19920112',N'nam',0961904631,N'phamnhat@gamil.com',N'số 411 Tam Trinh, Hoàng Mai, Hà Nội','20180102'),
		(N'Bùi Quang Linh','19920120',N'nam',0962904632,N'linhbui@gmail.com',N'số 11A Thái Hà, Trung Liệt, Đống Đa, Hà Nội','20180102'),
		(N'Chu Hà Phong','19920215',N'nam',0963904633,N'chuphong@gmail.com',N'số 131 Thái Thịnh, Thịnh Quang, Đống Đa, Hà Nội','20180102'),
		(N'Nguyễn Công Phú','19920918',N'nam',0964904634,N'nguyenphu@gmail.com',N'số 351 Cầu Giấy, Dịch Vọng, Cầu Giấy, Hà Nội','20180102'),
		(N'Đỗ Hoàng Phúc','19921011',N'nam',0965904635,N'dophuc@gmail.com',N'số 8 Lê Đại Hành, Hai Bà Trưng, Hà Nội','20180102'),
		(N'Nguyễn Minh Phương','19911104',N'nam',0966904636,N'minhphuong@gmail.com',N'số 186 Trương Định, Hai Bà Trưng, Hà Nội','20180102'),
		(N'Trần Hải Anh','19910724',N'nam',0967904637,N'haianh@gmail.com',N'số 463 Minh Khai, Vĩnh Tuy, Hai Bà Trưng, Hà Nội','20180102'),
		(N'Nguyễn Hồng Bàng','19990411',N'nam',0968904638,N'bangnguyen@gmail.com',N'số 66-68 Ngô Thì Nhậm, Hai Bà Trưng, Hà Nội','20180102'),
		(N'Nguyễn Đăng Bá','19910520',N'nam',0969904639,N'badang@gmail.com',N'số 163 Đại La, Đồng Tâm, Hai Bà Trương, Hà Nội','20180102'),
		(N'Lê Huy Bách','19910401',N'nam',0950904640,N'huybach@gmail.com',N'số 753 Giải Phóng, Giáp Bát, Hoàng Mai, Hà Nội','20180102'),
		(N'Hoàng Thái Bảo','19910420',N'nam',0951904641,N'baothai@gmail.com',N'số 277 Tam Trinh, Hoàng Văn Thụ, Hoàng Mai, Hà Nội','20180102'),
		(N'Nguyễn Phú Bằng','19910220',N'nam',0952904642,N'phubang@gmail.com',N'số 291 Nguyễn Văn Cừ, Ngọc Lâm, Long Biên, Hà Nội','20180102'),
		(N'An Hữu Biên','19910314',N'nam',0953904643,N'huubien@gmail.com',N'số 497 Nguyễn Trãi, Thanh Xuân, Hà Nội','20180102'),
		(N'Lê Văn Bình','19910424',N'nam',0954904644,N'lebinnh@gmail.com',N'số 317 Trường Trinh, Khương Trung, Thanh Xuân, Hà Nội','20180102'),
		(N'Nguyễn Thị Thu Hà','19900701',N'nữ',0955904645,N'hathu@gmail.com',N'số 315 Hà Huy Tập, Yên Viên, Gia Lâm, Hà Nội','20180102'),
		(N'Võ Duy Hải','19901208',N'nam',0956904646,N'vohai@gmail.com',N'389 Ngọc Hồi, Trấn Văn Điển, Thanh Trì, Hà Nội','20180102'),
		(N'Phạm Thị Hạnh','19900819',N'nữ',0957904647,N'hanhpham@gmail.com',N'số 30, Trần Hưng Đạo, Ba Vì, Hà Nội','20180102'),
		(N'Lê Đức Hiếu','19901209',N'nam',0958904648,N'duchieu@gmail.com',N'số 89 Tây Sơn, Đan Phượng, Hà Nội','20180102'),
		(N'Nguyễn Duy Hiệp','19900508',N'nam',0959904649,N'nguyenhieu@gmail.com',N'số 124 phố Xồm, Phúa Lâm, Hà Đông, Hà Nội','20180102'),
		(N'Đỗ Văn Hiệu','19900423',N'nam',0988907650,N'hieuva@gmail.com',N'số 403 Quang Trung, Hà Đông, Hà Nội','20180102')
GO



