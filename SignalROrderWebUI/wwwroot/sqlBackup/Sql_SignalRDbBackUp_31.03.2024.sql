USE [SignalRDb]
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [CategoryStatus]) VALUES (4, N'Hamburger', 1)
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [CategoryStatus]) VALUES (5, N'Pasta', 1)
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [CategoryStatus]) VALUES (6, N'Salad', 1)
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [CategoryStatus]) VALUES (7, N'Sweet', 0)
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [CategoryStatus]) VALUES (8, N'Beverage', 0)
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [CategoryStatus]) VALUES (16, N'Fries', 0)
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([ProductID], [ProductName], [Description], [Price], [ImageUrl], [ProductStatus], [CategoryID]) VALUES (3, N'SteakBurger', N'Veniam debitis quaerat officiis quasi cupiditate quo, quisquam velit, magnam voluptatem repellendus sed eaque ', CAST(25.00 AS Decimal(18, 2)), N'/feane-1.0.0/images/f1.png', 1, 4)
INSERT [dbo].[Products] ([ProductID], [ProductName], [Description], [Price], [ImageUrl], [ProductStatus], [CategoryID]) VALUES (4, N'ChickenBUrger', N'Veniam debitis quaerat officiis quasi cupiditate quo, quisquam velit, magnam voluptatem repellendus sed eaque ', CAST(20.00 AS Decimal(18, 2)), N'/feane-1.0.0/images/f2.png', 1, 4)
INSERT [dbo].[Products] ([ProductID], [ProductName], [Description], [Price], [ImageUrl], [ProductStatus], [CategoryID]) VALUES (5, N'PestoPasta', N'Veniam debitis quaerat officiis quasi cupiditate quo, quisquam velit, magnam voluptatem repellendus sed eaque ', CAST(20.00 AS Decimal(18, 2)), N'/feane-1.0.0/images/f3.png', 0, 7)
INSERT [dbo].[Products] ([ProductID], [ProductName], [Description], [Price], [ImageUrl], [ProductStatus], [CategoryID]) VALUES (6, N'Spagetti Bolonez', N'Veniam debitis quaerat officiis quasi cupiditate quo, quisquam velit, magnam voluptatem repellendus sed eaque ', CAST(19.00 AS Decimal(18, 2)), N'/feane-1.0.0/images/f4.png', 1, 4)
INSERT [dbo].[Products] ([ProductID], [ProductName], [Description], [Price], [ImageUrl], [ProductStatus], [CategoryID]) VALUES (7, N'Akdeniz Salatası', N'Veniam debitis quaerat officiis quasi cupiditate quo, quisquam velit, magnam voluptatem repellendus sed eaque ', CAST(15.00 AS Decimal(18, 2)), N'/feane-1.0.0/images/f5.png', 0, 6)
INSERT [dbo].[Products] ([ProductID], [ProductName], [Description], [Price], [ImageUrl], [ProductStatus], [CategoryID]) VALUES (10, N'Sezar Salata', N'Veniam debitis quaerat officiis quasi cupiditate quo, quisquam velit, magnam voluptatem repellendus sed eaque ', CAST(9.00 AS Decimal(18, 2)), N'/feane-1.0.0/images/f6.png', 1, 8)
INSERT [dbo].[Products] ([ProductID], [ProductName], [Description], [Price], [ImageUrl], [ProductStatus], [CategoryID]) VALUES (11, N'Puding24', N'Veniam debitis quaerat officiis quasi cupiditate quo, quisquam velit, magnam voluptatem repellendus sed eaque ', CAST(13.00 AS Decimal(18, 2)), N'/feane-1.0.0/images/f7.png', 0, 5)
INSERT [dbo].[Products] ([ProductID], [ProductName], [Description], [Price], [ImageUrl], [ProductStatus], [CategoryID]) VALUES (30, N'wqe24', N'dasdasdasd', CAST(23.00 AS Decimal(18, 2)), N'ewer24', 1, 5)
INSERT [dbo].[Products] ([ProductID], [ProductName], [Description], [Price], [ImageUrl], [ProductStatus], [CategoryID]) VALUES (35, N'string', N'string', CAST(0.00 AS Decimal(18, 2)), N'string', 1, 4)
INSERT [dbo].[Products] ([ProductID], [ProductName], [Description], [Price], [ImageUrl], [ProductStatus], [CategoryID]) VALUES (36, N'34', N'ewqrwer', CAST(234.00 AS Decimal(18, 2)), N'dfsdf', 1, 4)
INSERT [dbo].[Products] ([ProductID], [ProductName], [Description], [Price], [ImageUrl], [ProductStatus], [CategoryID]) VALUES (37, N'34', N'ewqrwer', CAST(234.00 AS Decimal(18, 2)), N'dfsdf', 1, 4)
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET IDENTITY_INSERT [dbo].[RestaurantTables] ON 

INSERT [dbo].[RestaurantTables] ([RestaurantTableID], [Name], [Status]) VALUES (1, N'Garden - 01', 1)
INSERT [dbo].[RestaurantTables] ([RestaurantTableID], [Name], [Status]) VALUES (2, N'Garden - 02', 0)
INSERT [dbo].[RestaurantTables] ([RestaurantTableID], [Name], [Status]) VALUES (3, N'Garden - 03', 1)
INSERT [dbo].[RestaurantTables] ([RestaurantTableID], [Name], [Status]) VALUES (4, N'Garden - 04', 1)
INSERT [dbo].[RestaurantTables] ([RestaurantTableID], [Name], [Status]) VALUES (5, N'Garden - 05', 0)
INSERT [dbo].[RestaurantTables] ([RestaurantTableID], [Name], [Status]) VALUES (7, N'Inside - 01', 1)
INSERT [dbo].[RestaurantTables] ([RestaurantTableID], [Name], [Status]) VALUES (8, N'Inside - 02', 1)
INSERT [dbo].[RestaurantTables] ([RestaurantTableID], [Name], [Status]) VALUES (9, N'Inside - 03', 0)
INSERT [dbo].[RestaurantTables] ([RestaurantTableID], [Name], [Status]) VALUES (10, N'Inside - 04', 1)
INSERT [dbo].[RestaurantTables] ([RestaurantTableID], [Name], [Status]) VALUES (11, N'Inside - 05', 1)
INSERT [dbo].[RestaurantTables] ([RestaurantTableID], [Name], [Status]) VALUES (13, N'PoolSide - 01', 0)
INSERT [dbo].[RestaurantTables] ([RestaurantTableID], [Name], [Status]) VALUES (14, N'PoolSide - 02', 1)
INSERT [dbo].[RestaurantTables] ([RestaurantTableID], [Name], [Status]) VALUES (15, N'PoolSide - 03', 0)
INSERT [dbo].[RestaurantTables] ([RestaurantTableID], [Name], [Status]) VALUES (18, N'PoolSide - :)', 0)
INSERT [dbo].[RestaurantTables] ([RestaurantTableID], [Name], [Status]) VALUES (20, N'Deneme', 0)
SET IDENTITY_INSERT [dbo].[RestaurantTables] OFF
GO
SET IDENTITY_INSERT [dbo].[Baskets] ON 

INSERT [dbo].[Baskets] ([BasketID], [Count], [ProductID], [Price], [TotalPrice], [RestaurantTableID]) VALUES (41, 1, 3, CAST(25.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 4)
INSERT [dbo].[Baskets] ([BasketID], [Count], [ProductID], [Price], [TotalPrice], [RestaurantTableID]) VALUES (42, 1, 10, CAST(9.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 4)
INSERT [dbo].[Baskets] ([BasketID], [Count], [ProductID], [Price], [TotalPrice], [RestaurantTableID]) VALUES (46, 1, 11, CAST(13.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 4)
INSERT [dbo].[Baskets] ([BasketID], [Count], [ProductID], [Price], [TotalPrice], [RestaurantTableID]) VALUES (47, 1, 7, CAST(15.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 4)
SET IDENTITY_INSERT [dbo].[Baskets] OFF
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([OrderID], [TableNumber], [Description], [TotalPrice], [OrderDate]) VALUES (14, N'Garden -01', N'Checked In', CAST(10.00 AS Decimal(18, 2)), CAST(N'2024-10-01' AS Date))
INSERT [dbo].[Orders] ([OrderID], [TableNumber], [Description], [TotalPrice], [OrderDate]) VALUES (16, N'Garden - 02', N'Costumer Sitting', CAST(15.00 AS Decimal(18, 2)), CAST(N'2024-09-01' AS Date))
INSERT [dbo].[Orders] ([OrderID], [TableNumber], [Description], [TotalPrice], [OrderDate]) VALUES (17, N'Inside - 01', N'Checked In', CAST(20.00 AS Decimal(18, 2)), CAST(N'2024-10-01' AS Date))
INSERT [dbo].[Orders] ([OrderID], [TableNumber], [Description], [TotalPrice], [OrderDate]) VALUES (18, N'Inside - 02 ', N'Costumer Sitting', CAST(26.00 AS Decimal(18, 2)), CAST(N'2024-08-01' AS Date))
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
SET IDENTITY_INSERT [dbo].[AspNetUsers] ON 

INSERT [dbo].[AspNetUsers] ([Id], [Name], [Surname], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (1, N'qwe', N'qwe', N'qweqwe', N'QWEQWE', N'deneme24@gmail.com', N'DENEME24@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEEdhrFqSmq5gljopoQTGR5fYw78cz+gqFduom6Ay73MmrVGUkvUESJJBCdcPWKiMOg==', N'JCIUZ3MGRUIJXNKVCF4FEK5DHILWSF5M', N'430d8be7-d9ad-4a32-bc8a-6cb9efba0302', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [Name], [Surname], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (2, N'Ahmet', N'Akbas', N'ilhan', N'ILHAN', N'aia@gmail.com', N'AIA@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAECXg3clb6YT0HSTZQ2X45fbw2zuLad6VKmVQJCOqTMahCSgk9Ez3BQa5dCvCKonqHg==', N'QRQMIT6UMMON5O44TQTIRIDL6U6ZTBFM', N'b53a291f-7cdf-4b64-9e20-dde1045486b7', N'123456aA+', 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [Name], [Surname], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (3, N'aw', N'ad', N'ssss', N'SSSS', N'aia@gmail.com', N'AIA@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAECW43ROSYYCjHbxNU+D0Cjloha5epjZbVGzHgNAG7WoMWR1xp/K91j8CGlH+S+XRog==', N'6P5RX2JJ54PDQT23S2BTCKSTUC47SNKF', N'fe003d3a-8e02-40b8-a1bd-ed73b6584527', NULL, 0, 0, NULL, 1, 0)
SET IDENTITY_INSERT [dbo].[AspNetUsers] OFF
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231226204857_initialize', N'6.0.25')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231228184011_mig_add_product_category_relation', N'6.0.25')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240106221927_mig_add_order', N'6.0.25')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240109183903_mig_add_money_case', N'6.0.25')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240109204622_order_add_Orderdate', N'6.0.25')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240109205526_order_delete', N'6.0.25')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240109205826_order_delete_datetime', N'6.0.25')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240109210220_order_delete_datetime2', N'6.0.25')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240109211217_add_migration_restaurantTable', N'6.0.25')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240113194600_mig_add_slider', N'6.0.25')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240114203423_mig_add_contact_new_columns', N'6.0.25')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240116161838_mig_add_basket_table', N'6.0.25')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240116165937_mig_add_basket_table_count', N'6.0.25')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240116170145_mig_add_basket_table_', N'6.0.25')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240122181040_mig_add_notification', N'6.0.25')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240122193250_mig_add_Notification_icon', N'6.0.25')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240126210502_mig_add_identity', N'6.0.25')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240127102216_mig_booking_description', N'6.0.25')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240127152423_mig_add_discount_status', N'6.0.25')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240129063019_tyring_to_correct', N'6.0.25')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240129064312_database_name_changes', N'6.0.25')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240129065243_database_name_changed_again', N'6.0.25')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240129070117_mig_add_message_table', N'6.0.25')
GO
SET IDENTITY_INSERT [dbo].[Abouts] ON 

INSERT [dbo].[Abouts] ([AboutID], [ImageUrl], [Title], [Description]) VALUES (3, N'/feane-1.0.0/images/about-img.png', N'We Are Master of Delicious', N'There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration
in some form, by injected humour, or randomised words which don''t look even slightly believable. If you
are going to use a passage of Lorem Ipsum, you need to be sure there isn''t anything embarrassing hidden in
the middle of text. All')
SET IDENTITY_INSERT [dbo].[Abouts] OFF
GO
SET IDENTITY_INSERT [dbo].[Bookings] ON 

INSERT [dbo].[Bookings] ([BookingID], [Name], [Phone], [Mail], [PersonCount], [Date], [Description]) VALUES (1, N'Ahmet', N'222', N'string', 2, CAST(N'2023-12-27T00:00:00.0000000' AS DateTime2), N'Cancelled')
INSERT [dbo].[Bookings] ([BookingID], [Name], [Phone], [Mail], [PersonCount], [Date], [Description]) VALUES (7, N'Ayşenur', N'334', N'string', 4, CAST(N'2024-01-21T00:00:00.0000000' AS DateTime2), N'Confirmed')
INSERT [dbo].[Bookings] ([BookingID], [Name], [Phone], [Mail], [PersonCount], [Date], [Description]) VALUES (8, N'Ali', N'444', N'dwdwed@dads.com', 6, CAST(N'2024-01-31T00:00:00.0000000' AS DateTime2), N'Confirmed')
INSERT [dbo].[Bookings] ([BookingID], [Name], [Phone], [Mail], [PersonCount], [Date], [Description]) VALUES (9, N'Veli', N'555', N'denemeahmet@gmail.com', 3, CAST(N'2024-01-17T00:00:00.0000000' AS DateTime2), N'Cancelled')
INSERT [dbo].[Bookings] ([BookingID], [Name], [Phone], [Mail], [PersonCount], [Date], [Description]) VALUES (17, N'asdad', N'asdasd', N'adadad@deneme.com', 3, CAST(N'2024-01-17T00:00:00.0000000' AS DateTime2), N'Confirmed')
INSERT [dbo].[Bookings] ([BookingID], [Name], [Phone], [Mail], [PersonCount], [Date], [Description]) VALUES (18, N'asd', N'qweqwe', N'deneme@deneme.com', 3, CAST(N'2024-01-25T00:00:00.0000000' AS DateTime2), N'Confirmed')
INSERT [dbo].[Bookings] ([BookingID], [Name], [Phone], [Mail], [PersonCount], [Date], [Description]) VALUES (19, N'wwww', N'1111', N'www@www.com', 5, CAST(N'2024-01-01T00:00:00.0000000' AS DateTime2), N'Confirmed')
INSERT [dbo].[Bookings] ([BookingID], [Name], [Phone], [Mail], [PersonCount], [Date], [Description]) VALUES (20, N'aaaaaa', N'222222', N'3333333@44444.com', 5, CAST(N'2024-01-05T00:00:00.0000000' AS DateTime2), N'Requested')
INSERT [dbo].[Bookings] ([BookingID], [Name], [Phone], [Mail], [PersonCount], [Date], [Description]) VALUES (21, N'asdasdasdasdadasd', N'234234234', N'asdasdasdasdasdasdad@deneme.com', 2, CAST(N'2024-01-01T00:00:00.0000000' AS DateTime2), N'Requested')
INSERT [dbo].[Bookings] ([BookingID], [Name], [Phone], [Mail], [PersonCount], [Date], [Description]) VALUES (22, N'ilhan24', N'242424', N'ilhan24@deneme.com', 5, CAST(N'2024-01-01T00:00:00.0000000' AS DateTime2), N'Requested')
SET IDENTITY_INSERT [dbo].[Bookings] OFF
GO
SET IDENTITY_INSERT [dbo].[Contacts] ON 

INSERT [dbo].[Contacts] ([ContactID], [Location], [Phone], [Mail], [FooterDescription], [FooterTitle], [OpenDaysDescription], [OpenHours], [Opendays]) VALUES (2, N'GoogleMapLink', N'+90 555 555 5555', N'try@gmail.com', N'Necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined with', N'Restaurant SignalR App', N'Open Days', N'10am - 22pm', N'7 Days of Week')
INSERT [dbo].[Contacts] ([ContactID], [Location], [Phone], [Mail], [FooterDescription], [FooterTitle], [OpenDaysDescription], [OpenHours], [Opendays]) VALUES (6, N'asd', N'33', N'ssss@wewee.com', N'sdfsdfafasdfwe wqererwqqwerqwe weqrqwerqwrqwer', N'qwe', N'2342', N'werwerwerwerwer', N'231234')
INSERT [dbo].[Contacts] ([ContactID], [Location], [Phone], [Mail], [FooterDescription], [FooterTitle], [OpenDaysDescription], [OpenHours], [Opendays]) VALUES (7, N'232323', N'53244234234234', N'234234@deme.com', N'wrewerwerwerwerwwdfdsaf asd', N'2324234234we', N'werwerwe', N'rwerwer', N'rwewerwerwer')
SET IDENTITY_INSERT [dbo].[Contacts] OFF
GO
SET IDENTITY_INSERT [dbo].[Discounts] ON 

INSERT [dbo].[Discounts] ([DiscountID], [Title], [Amount], [Description], [ImageUrl], [Status]) VALUES (3, N'Pizza Days', N'15', N'werwerwerwerwerwer', N'/feane-1.0.0/images/o2.jpg', 1)
INSERT [dbo].[Discounts] ([DiscountID], [Title], [Amount], [Description], [ImageUrl], [Status]) VALUES (4, N'Happy Wednesdays', N'30', N'asdasd', N'/feane-1.0.0/images/o2.jpg', 1)
INSERT [dbo].[Discounts] ([DiscountID], [Title], [Amount], [Description], [ImageUrl], [Status]) VALUES (5, N'Tasty Thursdays ', N'20', N'Bla', N'/feane-1.0.0/images/o2.jpg', 1)
INSERT [dbo].[Discounts] ([DiscountID], [Title], [Amount], [Description], [ImageUrl], [Status]) VALUES (6, N'werwer', N'234', N'ewrwer', N'https://static.toiimg.com/thumb/56047475.cms?imgsize=527860&width=509&height=340', 0)
INSERT [dbo].[Discounts] ([DiscountID], [Title], [Amount], [Description], [ImageUrl], [Status]) VALUES (7, N'asd', N'34', N'ads', N'asdasdasd', 0)
INSERT [dbo].[Discounts] ([DiscountID], [Title], [Amount], [Description], [ImageUrl], [Status]) VALUES (8, N'wqewqe', N'45', N'erwer', N'bla', 0)
INSERT [dbo].[Discounts] ([DiscountID], [Title], [Amount], [Description], [ImageUrl], [Status]) VALUES (9, N'asdd', N'324234234234', N'asdads', N'asdasdad', 0)
SET IDENTITY_INSERT [dbo].[Discounts] OFF
GO
SET IDENTITY_INSERT [dbo].[Features] ON 

INSERT [dbo].[Features] ([FeatureID], [Title1], [Description1], [Title2], [Description2], [Title3], [Description3]) VALUES (1, N'deneme124', N'des124', N'deneme224', N'des224', N'deneme324', N'des324')
SET IDENTITY_INSERT [dbo].[Features] OFF
GO
SET IDENTITY_INSERT [dbo].[Messages] ON 

INSERT [dbo].[Messages] ([MessageID], [NameSurname], [Mail], [Phone], [Subject], [MessageContent], [MessageSendDate], [Status]) VALUES (1, N'Ahmet İlhan Akbaş', N'deneme@deneme.com', N'555 555 55 55', N'Deneme', N'Bu bir deneme mesajıdır', CAST(N'2024-01-29T18:40:06.5619634' AS DateTime2), 0)
SET IDENTITY_INSERT [dbo].[Messages] OFF
GO
SET IDENTITY_INSERT [dbo].[MoneyCases] ON 

INSERT [dbo].[MoneyCases] ([MoneyCaseID], [TotalAmount]) VALUES (1, CAST(215.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[MoneyCases] OFF
GO
SET IDENTITY_INSERT [dbo].[Notifications] ON 

INSERT [dbo].[Notifications] ([NotificationID], [Type], [Icon], [Description], [Date], [Status]) VALUES (2, N'notif-icon notif-primary', N'la la-user-plus', N'New user registered.', CAST(N'2024-01-22T18:26:20.0670000' AS DateTime2), 0)
INSERT [dbo].[Notifications] ([NotificationID], [Type], [Icon], [Description], [Date], [Status]) VALUES (3, N'notif-icon notif-success"', N'la la-comment', N'New comment.', CAST(N'1988-03-29T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[Notifications] ([NotificationID], [Type], [Icon], [Description], [Date], [Status]) VALUES (6, N'notif-icon notif-danger', N'la la-heart', N'New Order.', CAST(N'1989-02-02T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[Notifications] ([NotificationID], [Type], [Icon], [Description], [Date], [Status]) VALUES (12, N'notif-icon notif-success"', N'la la-comment', N'New comment.', CAST(N'2024-05-05T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[Notifications] ([NotificationID], [Type], [Icon], [Description], [Date], [Status]) VALUES (16, N'notif-icon notif-primary', N'la la-heart', N'deneme242424', CAST(N'2024-01-23T00:00:00.0000000' AS DateTime2), 0)
SET IDENTITY_INSERT [dbo].[Notifications] OFF
GO
SET IDENTITY_INSERT [dbo].[Sliders] ON 

INSERT [dbo].[Sliders] ([SliderID], [Title1], [Title2], [Title3], [Description1], [Description2], [Description3]) VALUES (1, N'Delicious Pastas', N'Chinese Cuisine', N'Matchless Hamburgers', N'Doloremque, itaque aperiam facilis rerum, commodi, temporibus sapiente ad mollitia laborum quam quisquam esse error unde. Tempora ex doloremque, labore, sunt repellat dolore, iste magni quos nihil ducimus libero ipsam. ', N'Tempora ex doloremque, labore, sunt repellat dolore, iste magni quos nihil ducimus libero ipsam. Doloremque, itaque aperiam facilis rerum, commodi, temporibus sapiente ad mollitia laborum quam quisquam esse error unde.', N'Doloremque, itaque aperiam facilis rerum, commodi, temporibus sapiente ad mollitia laborum quam quisquam esse error unde. Tempora ex doloremque, labore, sunt repellat dolore, iste magni quos nihil ducimus libero ipsam. ')
SET IDENTITY_INSERT [dbo].[Sliders] OFF
GO
SET IDENTITY_INSERT [dbo].[SocialMedias] ON 

INSERT [dbo].[SocialMedias] ([SocialMediaID], [Title], [Url], [Icon]) VALUES (1, N'Facebook', N'#', N'fa fa-facebook')
INSERT [dbo].[SocialMedias] ([SocialMediaID], [Title], [Url], [Icon]) VALUES (3, N'Instagram', N'#', N'fa fa-instagram')
INSERT [dbo].[SocialMedias] ([SocialMediaID], [Title], [Url], [Icon]) VALUES (4, N'Linkedin', N'#', N'fa fa-linkedin')
INSERT [dbo].[SocialMedias] ([SocialMediaID], [Title], [Url], [Icon]) VALUES (5, N'Twitter', N'#', N'fa fa-twitter')
INSERT [dbo].[SocialMedias] ([SocialMediaID], [Title], [Url], [Icon]) VALUES (6, N'Pinterest', N'#', N'fa fa-pinterest')
SET IDENTITY_INSERT [dbo].[SocialMedias] OFF
GO
SET IDENTITY_INSERT [dbo].[Testimonials] ON 

INSERT [dbo].[Testimonials] ([TestimonialID], [Comment], [ImageUrl], [Name], [Status], [Title]) VALUES (1, N'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam', N'/feane-1.0.0/images/client1.jpg', N'Moana Michell', 1, N'magna aliqua')
INSERT [dbo].[Testimonials] ([TestimonialID], [Comment], [ImageUrl], [Name], [Status], [Title]) VALUES (2, N'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam', N'/feane-1.0.0/images/client2.jpg', N'Mike Hamell', 1, N'magna aliqua')
SET IDENTITY_INSERT [dbo].[Testimonials] OFF
GO
