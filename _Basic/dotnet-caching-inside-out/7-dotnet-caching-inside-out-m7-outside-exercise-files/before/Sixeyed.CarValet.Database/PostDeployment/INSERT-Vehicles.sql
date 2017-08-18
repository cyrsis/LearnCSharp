USE [CarValet]
GO
SET IDENTITY_INSERT [dbo].[Vehicles] ON 

GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (1, CAST(0x00009CF100000000 AS DateTime), NULL, N'Audi A3', N'http://upload.wikimedia.org/wikipedia/commons/thumb/0/09/2009_Audi_A3_%288PA%29_2.0_TDI_5-door_Sportback_%282011-04-02%29_01.jpg/320px-2009_Audi_A3_%288PA%29_2.0_TDI_5-door_Sportback_%282011-04-02%29_01.jpg', N'audi', N'a3', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (2, CAST(0x00005B4F00000000 AS DateTime), CAST(0x0000610400000000 AS DateTime), N'123GT', N'http://upload.wikimedia.org/wikipedia/commons/thumb/0/09/2009_Audi_A3_%288PA%29_2.0_TDI_5-door_Sportback_%282011-04-02%29_01.jpg/320px-2009_Audi_A3_%288PA%29_2.0_TDI_5-door_Sportback_%282011-04-02%29_01.jpg', N'volvo', N'amazon', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (3, CAST(0x00005B4F00000000 AS DateTime), CAST(0x000063DF00000000 AS DateTime), N'122', N'http://upload.wikimedia.org/wikipedia/commons/thumb/0/09/2009_Audi_A3_%288PA%29_2.0_TDI_5-door_Sportback_%282011-04-02%29_01.jpg/320px-2009_Audi_A3_%288PA%29_2.0_TDI_5-door_Sportback_%282011-04-02%29_01.jpg', N'volvo', N'amazon', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (4, CAST(0x000081D500000000 AS DateTime), CAST(0x0000878A00000000 AS DateTime), N'500 v1', N'http://cdn.carvalet.com/img/veh/abarth_500_1.png', N'abarth', N'500', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (5, CAST(0x00006F4900000000 AS DateTime), NULL, N'Grande Punto Hatchback v1', N'http://cdn.carvalet.com/img/veh/abarth_grande_punto_hatchback_1.png', N'abarth', N'grande_punto_hatchback', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (6, CAST(0x000092F400000000 AS DateTime), NULL, N'Punto Evo v1', N'http://cdn.carvalet.com/img/veh/abarth_punto_evo_1.png', N'abarth', N'punto_evo', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (7, CAST(0x0000834200000000 AS DateTime), NULL, N'16 v1', N'http://cdn.carvalet.com/img/veh/ac_16_1.png', N'ac', N'16', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (8, CAST(0x0000766B00000000 AS DateTime), NULL, N'Ace v1', N'http://cdn.carvalet.com/img/veh/ac_ace_1.png', N'ac', N'ace', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (9, CAST(0x00008A6500000000 AS DateTime), NULL, N'Cobra v1', N'http://cdn.carvalet.com/img/veh/ac_cobra_1.png', N'ac', N'cobra', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (10, CAST(0x0000699400000000 AS DateTime), NULL, N'500 v1', N'http://cdn.carvalet.com/img/veh/aixam_500_1.png', N'aixam', N'500', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (11, CAST(0x000095CF00000000 AS DateTime), NULL, N'500.5 v1', N'http://cdn.carvalet.com/img/veh/aixam_500.5_1.png', N'aixam', N'500.5', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (12, CAST(0x00007EFB00000000 AS DateTime), NULL, N'A751 v1', N'http://cdn.carvalet.com/img/veh/aixam_a751_1.png', N'aixam', N'a751', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (13, CAST(0x00006B0100000000 AS DateTime), NULL, N'Crossline v1', N'http://cdn.carvalet.com/img/veh/aixam_crossline_1.png', N'aixam', N'crossline', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (14, CAST(0x000092F400000000 AS DateTime), NULL, N'Roadline v1', N'http://cdn.carvalet.com/img/veh/aixam_roadline_1.png', N'aixam', N'roadline', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (15, CAST(0x0000682700000000 AS DateTime), CAST(0x0000682700000000 AS DateTime), N'145 v1', N'http://cdn.carvalet.com/img/veh/alfa_romeo_145_1.png', N'alfa_romeo', N'145', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (16, CAST(0x0000901A00000000 AS DateTime), CAST(0x0000918700000000 AS DateTime), N'146 v1', N'http://cdn.carvalet.com/img/veh/alfa_romeo_146_1.png', N'alfa_romeo', N'146', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (17, CAST(0x00006F4900000000 AS DateTime), NULL, N'147 v1', N'http://cdn.carvalet.com/img/veh/alfa_romeo_147_1.png', N'alfa_romeo', N'147', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (18, CAST(0x000074FE00000000 AS DateTime), NULL, N'155 v1', N'http://cdn.carvalet.com/img/veh/alfa_romeo_155_1.png', N'alfa_romeo', N'155', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (19, CAST(0x0000806800000000 AS DateTime), CAST(0x0000861D00000000 AS DateTime), N'156 v1', N'http://cdn.carvalet.com/img/veh/alfa_romeo_156_1.png', N'alfa_romeo', N'156', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (20, CAST(0x0000834200000000 AS DateTime), NULL, N'159 v1', N'http://cdn.carvalet.com/img/veh/alfa_romeo_159_1.png', N'alfa_romeo', N'159', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (21, CAST(0x00008A6500000000 AS DateTime), CAST(0x00008A6500000000 AS DateTime), N'166 v1', N'http://cdn.carvalet.com/img/veh/alfa_romeo_166_1.png', N'alfa_romeo', N'166', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (22, CAST(0x0000794600000000 AS DateTime), NULL, N'8C v1', N'http://cdn.carvalet.com/img/veh/alfa_romeo_8c_1.png', N'alfa_romeo', N'8c', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (23, CAST(0x0000806800000000 AS DateTime), CAST(0x0000861D00000000 AS DateTime), N'Brera v1', N'http://cdn.carvalet.com/img/veh/alfa_romeo_brera_1.png', N'alfa_romeo', N'brera', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (24, CAST(0x000081D500000000 AS DateTime), NULL, N'Giulia v1', N'http://cdn.carvalet.com/img/veh/alfa_romeo_giulia_1.png', N'alfa_romeo', N'giulia', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (25, CAST(0x000063DF00000000 AS DateTime), NULL, N'Giulietta v1', N'http://cdn.carvalet.com/img/veh/alfa_romeo_giulietta_1.png', N'alfa_romeo', N'giulietta', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (26, CAST(0x0000766B00000000 AS DateTime), CAST(0x000077D800000000 AS DateTime), N'Gt v1', N'http://cdn.carvalet.com/img/veh/alfa_romeo_gt_1.png', N'alfa_romeo', N'gt', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (27, CAST(0x000088F700000000 AS DateTime), NULL, N'Gtv v1', N'http://cdn.carvalet.com/img/veh/alfa_romeo_gtv_1.png', N'alfa_romeo', N'gtv', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (28, CAST(0x0000878A00000000 AS DateTime), NULL, N'Mito v1', N'http://cdn.carvalet.com/img/veh/alfa_romeo_mito_1.png', N'alfa_romeo', N'mito', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (29, CAST(0x0000901A00000000 AS DateTime), NULL, N'Spider v1', N'http://cdn.carvalet.com/img/veh/alfa_romeo_spider_1.png', N'alfa_romeo', N'spider', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (30, CAST(0x000098A900000000 AS DateTime), NULL, N'Atom v1', N'http://cdn.carvalet.com/img/veh/ariel_atom_1.png', N'ariel', N'atom', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (31, CAST(0x00006B0100000000 AS DateTime), NULL, N'Rocsta v1', N'http://cdn.carvalet.com/img/veh/asia_rocsta_1.png', N'asia', N'rocsta', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (32, CAST(0x00008BD200000000 AS DateTime), CAST(0x0000901A00000000 AS DateTime), N'Cygnet v1', N'http://cdn.carvalet.com/img/veh/aston_martin_cygnet_1.png', N'aston_martin', N'cygnet', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (33, CAST(0x0000946100000000 AS DateTime), NULL, N'Db7 v1', N'http://cdn.carvalet.com/img/veh/aston_martin_db7_1.png', N'aston_martin', N'db7', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (34, CAST(0x00007C2000000000 AS DateTime), CAST(0x00007D8D00000000 AS DateTime), N'Db9 v1', N'http://cdn.carvalet.com/img/veh/aston_martin_db9_1.png', N'aston_martin', N'db9', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (35, CAST(0x000070B600000000 AS DateTime), NULL, N'Dbs v1', N'http://cdn.carvalet.com/img/veh/aston_martin_dbs_1.png', N'aston_martin', N'dbs', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (36, CAST(0x0000973C00000000 AS DateTime), NULL, N'Lagonda v1', N'http://cdn.carvalet.com/img/veh/aston_martin_lagonda_1.png', N'aston_martin', N'lagonda', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (37, CAST(0x00006F4900000000 AS DateTime), CAST(0x0000739100000000 AS DateTime), N'Rapide v1', N'http://cdn.carvalet.com/img/veh/aston_martin_rapide_1.png', N'aston_martin', N'rapide', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (38, CAST(0x00007D8D00000000 AS DateTime), CAST(0x000081D500000000 AS DateTime), N'V8 v1', N'http://cdn.carvalet.com/img/veh/aston_martin_v8_1.png', N'aston_martin', N'v8', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (39, CAST(0x0000722300000000 AS DateTime), CAST(0x000074FE00000000 AS DateTime), N'Vanquish v1', N'http://cdn.carvalet.com/img/veh/aston_martin_vanquish_1.png', N'aston_martin', N'vanquish', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (40, CAST(0x0000918700000000 AS DateTime), NULL, N'Vantage v1', N'http://cdn.carvalet.com/img/veh/aston_martin_vantage_1.png', N'aston_martin', N'vantage', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (41, CAST(0x000066B900000000 AS DateTime), NULL, N'Virage v1', N'http://cdn.carvalet.com/img/veh/aston_martin_virage_1.png', N'aston_martin', N'virage', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (42, CAST(0x0000699400000000 AS DateTime), NULL, N'Volante v1', N'http://cdn.carvalet.com/img/veh/aston_martin_volante_1.png', N'aston_martin', N'volante', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (43, CAST(0x0000794600000000 AS DateTime), CAST(0x00007C2000000000 AS DateTime), N'100 v1', N'http://cdn.carvalet.com/img/veh/audi_100_1.png', N'audi', N'100', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (44, CAST(0x00008A6500000000 AS DateTime), NULL, N'80 v1', N'http://cdn.carvalet.com/img/veh/audi_80_1.png', N'audi', N'80', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (45, CAST(0x0000918700000000 AS DateTime), CAST(0x0000946100000000 AS DateTime), N'A1 v1', N'http://cdn.carvalet.com/img/veh/audi_a1_1.png', N'audi', N'a1', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (46, CAST(0x000098A900000000 AS DateTime), NULL, N'A2 v1', N'http://cdn.carvalet.com/img/veh/audi_a2_1.png', N'audi', N'a2', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (47, CAST(0x0000973C00000000 AS DateTime), CAST(0x0000973C00000000 AS DateTime), N'A4 v1', N'http://cdn.carvalet.com/img/veh/audi_a4_1.png', N'audi', N'a4', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (48, CAST(0x0000901A00000000 AS DateTime), CAST(0x0000901A00000000 AS DateTime), N'A4 Allroad v1', N'http://cdn.carvalet.com/img/veh/audi_a4_allroad_1.png', N'audi', N'a4_allroad', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (49, CAST(0x000095CF00000000 AS DateTime), NULL, N'A5 v1', N'http://cdn.carvalet.com/img/veh/audi_a5_1.png', N'audi', N'a5', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (50, CAST(0x000081D500000000 AS DateTime), NULL, N'A6 v1', N'http://cdn.carvalet.com/img/veh/audi_a6_1.png', N'audi', N'a6', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (51, CAST(0x000095CF00000000 AS DateTime), CAST(0x0000973C00000000 AS DateTime), N'A7 v1', N'http://cdn.carvalet.com/img/veh/audi_a7_1.png', N'audi', N'a7', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (52, CAST(0x0000766B00000000 AS DateTime), NULL, N'A8 v1', N'http://cdn.carvalet.com/img/veh/audi_a8_1.png', N'audi', N'a8', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (53, CAST(0x00008D3F00000000 AS DateTime), CAST(0x0000918700000000 AS DateTime), N'Allroad v1', N'http://cdn.carvalet.com/img/veh/audi_allroad_1.png', N'audi', N'allroad', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (54, CAST(0x000092F400000000 AS DateTime), NULL, N'Cabriolet v1', N'http://cdn.carvalet.com/img/veh/audi_cabriolet_1.png', N'audi', N'cabriolet', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (55, CAST(0x000081D500000000 AS DateTime), CAST(0x000084B000000000 AS DateTime), N'Convertible v1', N'http://cdn.carvalet.com/img/veh/audi_convertible_1.png', N'audi', N'convertible', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (56, CAST(0x00007D8D00000000 AS DateTime), CAST(0x0000806800000000 AS DateTime), N'Coupe v1', N'http://cdn.carvalet.com/img/veh/audi_coupe_1.png', N'audi', N'coupe', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (57, CAST(0x0000878A00000000 AS DateTime), CAST(0x0000878A00000000 AS DateTime), N'Q3 v1', N'http://cdn.carvalet.com/img/veh/audi_q3_1.png', N'audi', N'q3', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (58, CAST(0x0000722300000000 AS DateTime), CAST(0x0000739100000000 AS DateTime), N'Q5 v1', N'http://cdn.carvalet.com/img/veh/audi_q5_1.png', N'audi', N'q5', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (59, CAST(0x00008D3F00000000 AS DateTime), CAST(0x0000901A00000000 AS DateTime), N'Q7 v1', N'http://cdn.carvalet.com/img/veh/audi_q7_1.png', N'audi', N'q7', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (60, CAST(0x000088F700000000 AS DateTime), NULL, N'Quattro v1', N'http://cdn.carvalet.com/img/veh/audi_quattro_1.png', N'audi', N'quattro', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (61, CAST(0x00007EFB00000000 AS DateTime), NULL, N'R8 v1', N'http://cdn.carvalet.com/img/veh/audi_r8_1.png', N'audi', N'r8', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (62, CAST(0x00008D3F00000000 AS DateTime), CAST(0x0000918700000000 AS DateTime), N'Rs2 v1', N'http://cdn.carvalet.com/img/veh/audi_rs2_1.png', N'audi', N'rs2', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (63, CAST(0x0000834200000000 AS DateTime), CAST(0x0000834200000000 AS DateTime), N'Rs3 v1', N'http://cdn.carvalet.com/img/veh/audi_rs3_1.png', N'audi', N'rs3', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (64, CAST(0x000084B000000000 AS DateTime), CAST(0x0000861D00000000 AS DateTime), N'Rs4 v1', N'http://cdn.carvalet.com/img/veh/audi_rs4_1.png', N'audi', N'rs4', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (65, CAST(0x0000766B00000000 AS DateTime), CAST(0x0000766B00000000 AS DateTime), N'Rs5 v1', N'http://cdn.carvalet.com/img/veh/audi_rs5_1.png', N'audi', N'rs5', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (66, CAST(0x0000806800000000 AS DateTime), NULL, N'Rs6 v1', N'http://cdn.carvalet.com/img/veh/audi_rs6_1.png', N'audi', N'rs6', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (67, CAST(0x00007EFB00000000 AS DateTime), CAST(0x0000806800000000 AS DateTime), N'S3 v1', N'http://cdn.carvalet.com/img/veh/audi_s3_1.png', N'audi', N's3', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (68, CAST(0x000077D800000000 AS DateTime), CAST(0x000077D800000000 AS DateTime), N'S4 v1', N'http://cdn.carvalet.com/img/veh/audi_s4_1.png', N'audi', N's4', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (69, CAST(0x000092F400000000 AS DateTime), CAST(0x000098A900000000 AS DateTime), N'S5 v1', N'http://cdn.carvalet.com/img/veh/audi_s5_1.png', N'audi', N's5', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (70, CAST(0x00006F4900000000 AS DateTime), CAST(0x00006F4900000000 AS DateTime), N'S6 v1', N'http://cdn.carvalet.com/img/veh/audi_s6_1.png', N'audi', N's6', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (71, CAST(0x0000861D00000000 AS DateTime), CAST(0x00008BD200000000 AS DateTime), N'S8 v1', N'http://cdn.carvalet.com/img/veh/audi_s8_1.png', N'audi', N's8', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (72, CAST(0x00008D3F00000000 AS DateTime), NULL, N'Tt v1', N'http://cdn.carvalet.com/img/veh/audi_tt_1.png', N'audi', N'tt', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (73, CAST(0x000084B000000000 AS DateTime), CAST(0x0000878A00000000 AS DateTime), N'1100 v1', N'http://cdn.carvalet.com/img/veh/austin_1100_1.png', N'austin', N'1100', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (74, CAST(0x0000699400000000 AS DateTime), NULL, N'A35 v1', N'http://cdn.carvalet.com/img/veh/austin_a35_1.png', N'austin', N'a35', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (75, CAST(0x00008EAC00000000 AS DateTime), NULL, N'Allegro v1', N'http://cdn.carvalet.com/img/veh/austin_allegro_1.png', N'austin', N'allegro', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (76, CAST(0x000084B000000000 AS DateTime), NULL, N'Ambassador v1', N'http://cdn.carvalet.com/img/veh/austin_ambassador_1.png', N'austin', N'ambassador', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (77, CAST(0x00006C6E00000000 AS DateTime), CAST(0x00006F4900000000 AS DateTime), N'Healey v1', N'http://cdn.carvalet.com/img/veh/austin_healey_1.png', N'austin', N'healey', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (78, CAST(0x00008A6500000000 AS DateTime), CAST(0x00008BD200000000 AS DateTime), N'Maestro v1', N'http://cdn.carvalet.com/img/veh/austin_maestro_1.png', N'austin', N'maestro', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (79, CAST(0x00007D8D00000000 AS DateTime), CAST(0x00007EFB00000000 AS DateTime), N'Maxi v1', N'http://cdn.carvalet.com/img/veh/austin_maxi_1.png', N'austin', N'maxi', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (80, CAST(0x0000699400000000 AS DateTime), NULL, N'Metro v1', N'http://cdn.carvalet.com/img/veh/austin_metro_1.png', N'austin', N'metro', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (81, CAST(0x0000739100000000 AS DateTime), CAST(0x0000766B00000000 AS DateTime), N'Mini v1', N'http://cdn.carvalet.com/img/veh/austin_mini_1.png', N'austin', N'mini', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (82, CAST(0x00006DDC00000000 AS DateTime), CAST(0x00006F4900000000 AS DateTime), N'Montego v1', N'http://cdn.carvalet.com/img/veh/austin_montego_1.png', N'austin', N'montego', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (83, CAST(0x0000806800000000 AS DateTime), NULL, N'Seven v1', N'http://cdn.carvalet.com/img/veh/austin_seven_1.png', N'austin', N'seven', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (84, CAST(0x00008A6500000000 AS DateTime), CAST(0x00008D3F00000000 AS DateTime), N'Mono v1', N'http://cdn.carvalet.com/img/veh/bac_mono_1.png', N'bac', N'mono', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (85, CAST(0x0000834200000000 AS DateTime), NULL, N'Arnage v1', N'http://cdn.carvalet.com/img/veh/bentley_arnage_1.png', N'bentley', N'arnage', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (86, CAST(0x0000878A00000000 AS DateTime), NULL, N'Azure v1', N'http://cdn.carvalet.com/img/veh/bentley_azure_1.png', N'bentley', N'azure', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (87, CAST(0x00008EAC00000000 AS DateTime), NULL, N'Brooklands v1', N'http://cdn.carvalet.com/img/veh/bentley_brooklands_1.png', N'bentley', N'brooklands', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (88, CAST(0x00007AB300000000 AS DateTime), NULL, N'Continental v1', N'http://cdn.carvalet.com/img/veh/bentley_continental_1.png', N'bentley', N'continental', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (89, CAST(0x0000834200000000 AS DateTime), CAST(0x0000878A00000000 AS DateTime), N'Continental Flying Spur v1', N'http://cdn.carvalet.com/img/veh/bentley_continental_flying_spur_1.png', N'bentley', N'continental_flying_spur', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (90, CAST(0x00006C6E00000000 AS DateTime), CAST(0x000070B600000000 AS DateTime), N'Continental Gt v1', N'http://cdn.carvalet.com/img/veh/bentley_continental_gt_1.png', N'bentley', N'continental_gt', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (91, CAST(0x000063DF00000000 AS DateTime), NULL, N'Continental Gtc v1', N'http://cdn.carvalet.com/img/veh/bentley_continental_gtc_1.png', N'bentley', N'continental_gtc', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (92, CAST(0x0000722300000000 AS DateTime), CAST(0x0000766B00000000 AS DateTime), N'Continental Supersports v1', N'http://cdn.carvalet.com/img/veh/bentley_continental_supersports_1.png', N'bentley', N'continental_supersports', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (93, CAST(0x0000918700000000 AS DateTime), NULL, N'Corniche v1', N'http://cdn.carvalet.com/img/veh/bentley_corniche_1.png', N'bentley', N'corniche', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (94, CAST(0x00008A6500000000 AS DateTime), NULL, N'Eight v1', N'http://cdn.carvalet.com/img/veh/bentley_eight_1.png', N'bentley', N'eight', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (95, CAST(0x000077D800000000 AS DateTime), CAST(0x00007D8D00000000 AS DateTime), N'Mkvi v1', N'http://cdn.carvalet.com/img/veh/bentley_mkvi_1.png', N'bentley', N'mkvi', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (96, CAST(0x000077D800000000 AS DateTime), NULL, N'Mulsanne v1', N'http://cdn.carvalet.com/img/veh/bentley_mulsanne_1.png', N'bentley', N'mulsanne', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (97, CAST(0x000063DF00000000 AS DateTime), CAST(0x0000699400000000 AS DateTime), N'R-Type v1', N'http://cdn.carvalet.com/img/veh/bentley_r-type_1.png', N'bentley', N'r-type', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (98, CAST(0x0000946100000000 AS DateTime), NULL, N'Series Ii v1', N'http://cdn.carvalet.com/img/veh/bentley_series_ii_1.png', N'bentley', N'series_ii', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (99, CAST(0x000081D500000000 AS DateTime), NULL, N'Series Iii v1', N'http://cdn.carvalet.com/img/veh/bentley_series_iii_1.png', N'bentley', N'series_iii', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (100, CAST(0x0000973C00000000 AS DateTime), NULL, N'T Series v1', N'http://cdn.carvalet.com/img/veh/bentley_t_series_1.png', N'bentley', N't_series', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (101, CAST(0x00007C2000000000 AS DateTime), NULL, N'Turbo R v1', N'http://cdn.carvalet.com/img/veh/bentley_turbo_r_1.png', N'bentley', N'turbo_r', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (102, CAST(0x0000806800000000 AS DateTime), NULL, N'1 Series v1', N'http://cdn.carvalet.com/img/veh/bmw_1_series_1.png', N'bmw', N'1_series', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (103, CAST(0x0000682700000000 AS DateTime), NULL, N'1 Series M Coupe v1', N'http://cdn.carvalet.com/img/veh/bmw_1_series_m_coupe_1.png', N'bmw', N'1_series_m_coupe', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (104, CAST(0x000074FE00000000 AS DateTime), NULL, N'3 Series v1', N'http://cdn.carvalet.com/img/veh/bmw_3_series_1.png', N'bmw', N'3_series', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (105, CAST(0x000077D800000000 AS DateTime), CAST(0x00007AB300000000 AS DateTime), N'5 Series v1', N'http://cdn.carvalet.com/img/veh/bmw_5_series_1.png', N'bmw', N'5_series', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (106, CAST(0x000074FE00000000 AS DateTime), CAST(0x0000766B00000000 AS DateTime), N'6 Series v1', N'http://cdn.carvalet.com/img/veh/bmw_6_series_1.png', N'bmw', N'6_series', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (107, CAST(0x000070B600000000 AS DateTime), CAST(0x0000739100000000 AS DateTime), N'7 Series v1', N'http://cdn.carvalet.com/img/veh/bmw_7_series_1.png', N'bmw', N'7_series', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (108, CAST(0x0000901A00000000 AS DateTime), CAST(0x0000901A00000000 AS DateTime), N'8 Series v1', N'http://cdn.carvalet.com/img/veh/bmw_8_series_1.png', N'bmw', N'8_series', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (109, CAST(0x0000739100000000 AS DateTime), NULL, N'Alpina v1', N'http://cdn.carvalet.com/img/veh/bmw_alpina_1.png', N'bmw', N'alpina', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (110, CAST(0x0000973C00000000 AS DateTime), CAST(0x00009B8400000000 AS DateTime), N'M Coupe v1', N'http://cdn.carvalet.com/img/veh/bmw_m_coupe_1.png', N'bmw', N'm_coupe', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (111, CAST(0x00006B0100000000 AS DateTime), CAST(0x00006B0100000000 AS DateTime), N'M Roadster v1', N'http://cdn.carvalet.com/img/veh/bmw_m_roadster_1.png', N'bmw', N'm_roadster', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (112, CAST(0x0000918700000000 AS DateTime), CAST(0x000092F400000000 AS DateTime), N'M3 v1', N'http://cdn.carvalet.com/img/veh/bmw_m3_1.png', N'bmw', N'm3', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (113, CAST(0x00006C6E00000000 AS DateTime), NULL, N'M5 v1', N'http://cdn.carvalet.com/img/veh/bmw_m5_1.png', N'bmw', N'm5', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (114, CAST(0x0000654C00000000 AS DateTime), NULL, N'M6 v1', N'http://cdn.carvalet.com/img/veh/bmw_m6_1.png', N'bmw', N'm6', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (115, CAST(0x0000861D00000000 AS DateTime), CAST(0x000088F700000000 AS DateTime), N'X1 v1', N'http://cdn.carvalet.com/img/veh/bmw_x1_1.png', N'bmw', N'x1', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (116, CAST(0x0000861D00000000 AS DateTime), CAST(0x0000861D00000000 AS DateTime), N'X3 v1', N'http://cdn.carvalet.com/img/veh/bmw_x3_1.png', N'bmw', N'x3', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (117, CAST(0x0000901A00000000 AS DateTime), CAST(0x0000918700000000 AS DateTime), N'X5 v1', N'http://cdn.carvalet.com/img/veh/bmw_x5_1.png', N'bmw', N'x5', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (118, CAST(0x0000946100000000 AS DateTime), NULL, N'X6 v1', N'http://cdn.carvalet.com/img/veh/bmw_x6_1.png', N'bmw', N'x6', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (119, CAST(0x0000901A00000000 AS DateTime), CAST(0x0000946100000000 AS DateTime), N'Z1 v1', N'http://cdn.carvalet.com/img/veh/bmw_z1_1.png', N'bmw', N'z1', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (120, CAST(0x000092F400000000 AS DateTime), NULL, N'Z3 v1', N'http://cdn.carvalet.com/img/veh/bmw_z3_1.png', N'bmw', N'z3', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (121, CAST(0x00008BD200000000 AS DateTime), CAST(0x0000918700000000 AS DateTime), N'Z4 v1', N'http://cdn.carvalet.com/img/veh/bmw_z4_1.png', N'bmw', N'z4', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (122, CAST(0x00008BD200000000 AS DateTime), CAST(0x00008EAC00000000 AS DateTime), N'Z8 v1', N'http://cdn.carvalet.com/img/veh/bmw_z8_1.png', N'bmw', N'z8', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (123, CAST(0x0000973C00000000 AS DateTime), NULL, N'Veyron v1', N'http://cdn.carvalet.com/img/veh/bugatti_veyron_1.png', N'bugatti', N'veyron', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (124, CAST(0x000095CF00000000 AS DateTime), NULL, N'Special v1', N'http://cdn.carvalet.com/img/veh/buick_special_1.png', N'buick', N'special', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (125, CAST(0x0000699400000000 AS DateTime), NULL, N'Allante v1', N'http://cdn.carvalet.com/img/veh/cadillac_allante_1.png', N'cadillac', N'allante', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (126, CAST(0x000070B600000000 AS DateTime), NULL, N'Bls v1', N'http://cdn.carvalet.com/img/veh/cadillac_bls_1.png', N'cadillac', N'bls', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (127, CAST(0x0000739100000000 AS DateTime), NULL, N'Cts v1', N'http://cdn.carvalet.com/img/veh/cadillac_cts_1.png', N'cadillac', N'cts', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (128, CAST(0x00006C6E00000000 AS DateTime), CAST(0x00006F4900000000 AS DateTime), N'Eldorado v1', N'http://cdn.carvalet.com/img/veh/cadillac_eldorado_1.png', N'cadillac', N'eldorado', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (129, CAST(0x000092F400000000 AS DateTime), CAST(0x000092F400000000 AS DateTime), N'Escalade v1', N'http://cdn.carvalet.com/img/veh/cadillac_escalade_1.png', N'cadillac', N'escalade', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (130, CAST(0x0000878A00000000 AS DateTime), NULL, N'Srx v1', N'http://cdn.carvalet.com/img/veh/cadillac_srx_1.png', N'cadillac', N'srx', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (131, CAST(0x00007C2000000000 AS DateTime), CAST(0x0000806800000000 AS DateTime), N'Sts v1', N'http://cdn.carvalet.com/img/veh/cadillac_sts_1.png', N'cadillac', N'sts', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (132, CAST(0x0000861D00000000 AS DateTime), CAST(0x0000878A00000000 AS DateTime), N'Xlr v1', N'http://cdn.carvalet.com/img/veh/cadillac_xlr_1.png', N'cadillac', N'xlr', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (133, CAST(0x000074FE00000000 AS DateTime), NULL, N'Seven v1', N'http://cdn.carvalet.com/img/veh/caterham_seven_1.png', N'caterham', N'seven', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (134, CAST(0x000098A900000000 AS DateTime), CAST(0x00009B8400000000 AS DateTime), N'Super Sprint v1', N'http://cdn.carvalet.com/img/veh/caterham_super_sprint_1.png', N'caterham', N'super_sprint', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (135, CAST(0x00007D8D00000000 AS DateTime), CAST(0x00007EFB00000000 AS DateTime), N'Astro v1', N'http://cdn.carvalet.com/img/veh/chevrolet_astro_1.png', N'chevrolet', N'astro', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (136, CAST(0x00008BD200000000 AS DateTime), NULL, N'Avalanche v1', N'http://cdn.carvalet.com/img/veh/chevrolet_avalanche_1.png', N'chevrolet', N'avalanche', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (137, CAST(0x00006DDC00000000 AS DateTime), NULL, N'Aveo v1', N'http://cdn.carvalet.com/img/veh/chevrolet_aveo_1.png', N'chevrolet', N'aveo', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (138, CAST(0x000088F700000000 AS DateTime), NULL, N'Blazer v1', N'http://cdn.carvalet.com/img/veh/chevrolet_blazer_1.png', N'chevrolet', N'blazer', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (139, CAST(0x000098A900000000 AS DateTime), CAST(0x00009B8400000000 AS DateTime), N'Camaro v1', N'http://cdn.carvalet.com/img/veh/chevrolet_camaro_1.png', N'chevrolet', N'camaro', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (140, CAST(0x000066B900000000 AS DateTime), CAST(0x000066B900000000 AS DateTime), N'Captiva v1', N'http://cdn.carvalet.com/img/veh/chevrolet_captiva_1.png', N'chevrolet', N'captiva', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (141, CAST(0x0000878A00000000 AS DateTime), NULL, N'Corvette v1', N'http://cdn.carvalet.com/img/veh/chevrolet_corvette_1.png', N'chevrolet', N'corvette', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (142, CAST(0x000063DF00000000 AS DateTime), NULL, N'Cruze v1', N'http://cdn.carvalet.com/img/veh/chevrolet_cruze_1.png', N'chevrolet', N'cruze', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (143, CAST(0x00007D8D00000000 AS DateTime), CAST(0x00007D8D00000000 AS DateTime), N'Epica v1', N'http://cdn.carvalet.com/img/veh/chevrolet_epica_1.png', N'chevrolet', N'epica', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (144, CAST(0x000098A900000000 AS DateTime), CAST(0x00009A1600000000 AS DateTime), N'Gmc v1', N'http://cdn.carvalet.com/img/veh/chevrolet_gmc_1.png', N'chevrolet', N'gmc', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (145, CAST(0x00008D3F00000000 AS DateTime), CAST(0x0000901A00000000 AS DateTime), N'Kalos v1', N'http://cdn.carvalet.com/img/veh/chevrolet_kalos_1.png', N'chevrolet', N'kalos', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (146, CAST(0x000084B000000000 AS DateTime), CAST(0x0000878A00000000 AS DateTime), N'Lacetti v1', N'http://cdn.carvalet.com/img/veh/chevrolet_lacetti_1.png', N'chevrolet', N'lacetti', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (147, CAST(0x0000878A00000000 AS DateTime), CAST(0x00008BD200000000 AS DateTime), N'Matiz v1', N'http://cdn.carvalet.com/img/veh/chevrolet_matiz_1.png', N'chevrolet', N'matiz', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (148, CAST(0x00008EAC00000000 AS DateTime), NULL, N'Orlando v1', N'http://cdn.carvalet.com/img/veh/chevrolet_orlando_1.png', N'chevrolet', N'orlando', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (149, CAST(0x0000918700000000 AS DateTime), CAST(0x000092F400000000 AS DateTime), N'Silverado v1', N'http://cdn.carvalet.com/img/veh/chevrolet_silverado_1.png', N'chevrolet', N'silverado', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (150, CAST(0x0000878A00000000 AS DateTime), CAST(0x00008A6500000000 AS DateTime), N'Spark v1', N'http://cdn.carvalet.com/img/veh/chevrolet_spark_1.png', N'chevrolet', N'spark', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (151, CAST(0x0000878A00000000 AS DateTime), CAST(0x000088F700000000 AS DateTime), N'Tacuma v1', N'http://cdn.carvalet.com/img/veh/chevrolet_tacuma_1.png', N'chevrolet', N'tacuma', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (152, CAST(0x000070B600000000 AS DateTime), CAST(0x000070B600000000 AS DateTime), N'300C v1', N'http://cdn.carvalet.com/img/veh/chrysler_300c_1.png', N'chrysler', N'300c', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (153, CAST(0x000098A900000000 AS DateTime), NULL, N'Crossfire v1', N'http://cdn.carvalet.com/img/veh/chrysler_crossfire_1.png', N'chrysler', N'crossfire', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (154, CAST(0x00008D3F00000000 AS DateTime), NULL, N'Delta v1', N'http://cdn.carvalet.com/img/veh/chrysler_delta_1.png', N'chrysler', N'delta', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (155, CAST(0x000098A900000000 AS DateTime), NULL, N'Grand Voyager v1', N'http://cdn.carvalet.com/img/veh/chrysler_grand_voyager_1.png', N'chrysler', N'grand_voyager', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (156, CAST(0x000063DF00000000 AS DateTime), NULL, N'Le Baron v1', N'http://cdn.carvalet.com/img/veh/chrysler_le_baron_1.png', N'chrysler', N'le_baron', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (157, CAST(0x0000699400000000 AS DateTime), CAST(0x00006C6E00000000 AS DateTime), N'Neon v1', N'http://cdn.carvalet.com/img/veh/chrysler_neon_1.png', N'chrysler', N'neon', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (158, CAST(0x00007AB300000000 AS DateTime), CAST(0x00007C2000000000 AS DateTime), N'Prowler v1', N'http://cdn.carvalet.com/img/veh/chrysler_prowler_1.png', N'chrysler', N'prowler', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (159, CAST(0x0000682700000000 AS DateTime), CAST(0x00006B0100000000 AS DateTime), N'Pt Cruiser v1', N'http://cdn.carvalet.com/img/veh/chrysler_pt_cruiser_1.png', N'chrysler', N'pt_cruiser', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (160, CAST(0x00007D8D00000000 AS DateTime), CAST(0x0000806800000000 AS DateTime), N'Sebring v1', N'http://cdn.carvalet.com/img/veh/chrysler_sebring_1.png', N'chrysler', N'sebring', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (161, CAST(0x00008EAC00000000 AS DateTime), NULL, N'Voyager v1', N'http://cdn.carvalet.com/img/veh/chrysler_voyager_1.png', N'chrysler', N'voyager', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (162, CAST(0x00008EAC00000000 AS DateTime), CAST(0x000092F400000000 AS DateTime), N'Ypsilon v1', N'http://cdn.carvalet.com/img/veh/chrysler_ypsilon_1.png', N'chrysler', N'ypsilon', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (163, CAST(0x000074FE00000000 AS DateTime), NULL, N'2 Cv v1', N'http://cdn.carvalet.com/img/veh/citroen_2_cv_1.png', N'citroen', N'2_cv', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (164, CAST(0x0000682700000000 AS DateTime), CAST(0x0000682700000000 AS DateTime), N'Ax v1', N'http://cdn.carvalet.com/img/veh/citroen_ax_1.png', N'citroen', N'ax', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (165, CAST(0x000098A900000000 AS DateTime), CAST(0x000098A900000000 AS DateTime), N'Berlingo v1', N'http://cdn.carvalet.com/img/veh/citroen_berlingo_1.png', N'citroen', N'berlingo', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (166, CAST(0x0000722300000000 AS DateTime), NULL, N'Berlingo Multispace v1', N'http://cdn.carvalet.com/img/veh/citroen_berlingo_multispace_1.png', N'citroen', N'berlingo_multispace', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (167, CAST(0x000095CF00000000 AS DateTime), CAST(0x00009B8400000000 AS DateTime), N'C Zero v1', N'http://cdn.carvalet.com/img/veh/citroen_c_zero_1.png', N'citroen', N'c_zero', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (168, CAST(0x000088F700000000 AS DateTime), NULL, N'C1 v1', N'http://cdn.carvalet.com/img/veh/citroen_c1_1.png', N'citroen', N'c1', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (169, CAST(0x000084B000000000 AS DateTime), CAST(0x000084B000000000 AS DateTime), N'C2 v1', N'http://cdn.carvalet.com/img/veh/citroen_c2_1.png', N'citroen', N'c2', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (170, CAST(0x0000918700000000 AS DateTime), CAST(0x0000973C00000000 AS DateTime), N'C3 v1', N'http://cdn.carvalet.com/img/veh/citroen_c3_1.png', N'citroen', N'c3', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (171, CAST(0x00008D3F00000000 AS DateTime), NULL, N'C3 Picasso v1', N'http://cdn.carvalet.com/img/veh/citroen_c3_picasso_1.png', N'citroen', N'c3_picasso', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (172, CAST(0x000077D800000000 AS DateTime), NULL, N'C4 v1', N'http://cdn.carvalet.com/img/veh/citroen_c4_1.png', N'citroen', N'c4', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (173, CAST(0x00007EFB00000000 AS DateTime), NULL, N'C4 Grand Picasso v1', N'http://cdn.carvalet.com/img/veh/citroen_c4_grand_picasso_1.png', N'citroen', N'c4_grand_picasso', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (174, CAST(0x00007AB300000000 AS DateTime), CAST(0x00007C2000000000 AS DateTime), N'C4 Picasso v1', N'http://cdn.carvalet.com/img/veh/citroen_c4_picasso_1.png', N'citroen', N'c4_picasso', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (175, CAST(0x0000973C00000000 AS DateTime), NULL, N'C5 v1', N'http://cdn.carvalet.com/img/veh/citroen_c5_1.png', N'citroen', N'c5', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (176, CAST(0x000095CF00000000 AS DateTime), CAST(0x00009A1600000000 AS DateTime), N'C6 v1', N'http://cdn.carvalet.com/img/veh/citroen_c6_1.png', N'citroen', N'c6', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (177, CAST(0x0000918700000000 AS DateTime), CAST(0x0000918700000000 AS DateTime), N'C8 v1', N'http://cdn.carvalet.com/img/veh/citroen_c8_1.png', N'citroen', N'c8', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (178, CAST(0x0000682700000000 AS DateTime), NULL, N'C-Crosser v1', N'http://cdn.carvalet.com/img/veh/citroen_c-crosser_1.png', N'citroen', N'c-crosser', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (179, CAST(0x0000722300000000 AS DateTime), CAST(0x0000766B00000000 AS DateTime), N'Dispatch Combi v1', N'http://cdn.carvalet.com/img/veh/citroen_dispatch_combi_1.png', N'citroen', N'dispatch_combi', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (180, CAST(0x00008D3F00000000 AS DateTime), NULL, N'Ds v1', N'http://cdn.carvalet.com/img/veh/citroen_ds_1.png', N'citroen', N'ds', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (181, CAST(0x000066B900000000 AS DateTime), NULL, N'Ds3 v1', N'http://cdn.carvalet.com/img/veh/citroen_ds3_1.png', N'citroen', N'ds3', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (182, CAST(0x00008D3F00000000 AS DateTime), NULL, N'Ds4 v1', N'http://cdn.carvalet.com/img/veh/citroen_ds4_1.png', N'citroen', N'ds4', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (183, CAST(0x0000901A00000000 AS DateTime), CAST(0x0000901A00000000 AS DateTime), N'Nemo v1', N'http://cdn.carvalet.com/img/veh/citroen_nemo_1.png', N'citroen', N'nemo', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (184, CAST(0x000095CF00000000 AS DateTime), CAST(0x00009A1600000000 AS DateTime), N'Nemo Multispace v1', N'http://cdn.carvalet.com/img/veh/citroen_nemo_multispace_1.png', N'citroen', N'nemo_multispace', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (185, CAST(0x000081D500000000 AS DateTime), NULL, N'Saxo v1', N'http://cdn.carvalet.com/img/veh/citroen_saxo_1.png', N'citroen', N'saxo', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (186, CAST(0x00008A6500000000 AS DateTime), CAST(0x00008D3F00000000 AS DateTime), N'Sm v1', N'http://cdn.carvalet.com/img/veh/citroen_sm_1.png', N'citroen', N'sm', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (187, CAST(0x00006C6E00000000 AS DateTime), NULL, N'Synergie v1', N'http://cdn.carvalet.com/img/veh/citroen_synergie_1.png', N'citroen', N'synergie', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (188, CAST(0x000098A900000000 AS DateTime), NULL, N'Xantia v1', N'http://cdn.carvalet.com/img/veh/citroen_xantia_1.png', N'citroen', N'xantia', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (189, CAST(0x000081D500000000 AS DateTime), NULL, N'Xsara v1', N'http://cdn.carvalet.com/img/veh/citroen_xsara_1.png', N'citroen', N'xsara', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (190, CAST(0x00006B0100000000 AS DateTime), NULL, N'Xsara Picasso v1', N'http://cdn.carvalet.com/img/veh/citroen_xsara_picasso_1.png', N'citroen', N'xsara_picasso', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (191, CAST(0x000066B900000000 AS DateTime), NULL, N'Zx v1', N'http://cdn.carvalet.com/img/veh/citroen_zx_1.png', N'citroen', N'zx', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (192, CAST(0x000088F700000000 AS DateTime), NULL, N'C6 v1', N'http://cdn.carvalet.com/img/veh/corvette_c6_1.png', N'corvette', N'c6', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (193, CAST(0x000095CF00000000 AS DateTime), CAST(0x000095CF00000000 AS DateTime), N'Z06 v1', N'http://cdn.carvalet.com/img/veh/corvette_z06_1.png', N'corvette', N'z06', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (194, CAST(0x000088F700000000 AS DateTime), NULL, N'Denem v1', N'http://cdn.carvalet.com/img/veh/dacia_denem_1.png', N'dacia', N'denem', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (195, CAST(0x0000699400000000 AS DateTime), CAST(0x00006C6E00000000 AS DateTime), N'Kalos v1', N'http://cdn.carvalet.com/img/veh/daewoo_kalos_1.png', N'daewoo', N'kalos', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (196, CAST(0x000066B900000000 AS DateTime), NULL, N'Korando v1', N'http://cdn.carvalet.com/img/veh/daewoo_korando_1.png', N'daewoo', N'korando', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (197, CAST(0x00006B0100000000 AS DateTime), CAST(0x00006F4900000000 AS DateTime), N'Lacetti v1', N'http://cdn.carvalet.com/img/veh/daewoo_lacetti_1.png', N'daewoo', N'lacetti', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (198, CAST(0x000095CF00000000 AS DateTime), NULL, N'Lanos v1', N'http://cdn.carvalet.com/img/veh/daewoo_lanos_1.png', N'daewoo', N'lanos', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (199, CAST(0x0000766B00000000 AS DateTime), CAST(0x0000766B00000000 AS DateTime), N'Leganza v1', N'http://cdn.carvalet.com/img/veh/daewoo_leganza_1.png', N'daewoo', N'leganza', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (200, CAST(0x00007D8D00000000 AS DateTime), NULL, N'Matiz v1', N'http://cdn.carvalet.com/img/veh/daewoo_matiz_1.png', N'daewoo', N'matiz', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (201, CAST(0x000074FE00000000 AS DateTime), CAST(0x00007AB300000000 AS DateTime), N'Musso v1', N'http://cdn.carvalet.com/img/veh/daewoo_musso_1.png', N'daewoo', N'musso', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (202, CAST(0x0000834200000000 AS DateTime), NULL, N'Nexia v1', N'http://cdn.carvalet.com/img/veh/daewoo_nexia_1.png', N'daewoo', N'nexia', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (203, CAST(0x0000834200000000 AS DateTime), CAST(0x0000834200000000 AS DateTime), N'Nubira v1', N'http://cdn.carvalet.com/img/veh/daewoo_nubira_1.png', N'daewoo', N'nubira', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (204, CAST(0x0000946100000000 AS DateTime), CAST(0x000098A900000000 AS DateTime), N'Tacuma v1', N'http://cdn.carvalet.com/img/veh/daewoo_tacuma_1.png', N'daewoo', N'tacuma', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (205, CAST(0x0000834200000000 AS DateTime), CAST(0x000084B000000000 AS DateTime), N'Charade v1', N'http://cdn.carvalet.com/img/veh/daihatsu_charade_1.png', N'daihatsu', N'charade', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (206, CAST(0x0000682700000000 AS DateTime), NULL, N'Copen v1', N'http://cdn.carvalet.com/img/veh/daihatsu_copen_1.png', N'daihatsu', N'copen', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (207, CAST(0x000081D500000000 AS DateTime), CAST(0x000084B000000000 AS DateTime), N'Cuore v1', N'http://cdn.carvalet.com/img/veh/daihatsu_cuore_1.png', N'daihatsu', N'cuore', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (208, CAST(0x00006F4900000000 AS DateTime), NULL, N'Fourtrak v1', N'http://cdn.carvalet.com/img/veh/daihatsu_fourtrak_1.png', N'daihatsu', N'fourtrak', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (209, CAST(0x000077D800000000 AS DateTime), CAST(0x000077D800000000 AS DateTime), N'Grand Move v1', N'http://cdn.carvalet.com/img/veh/daihatsu_grand_move_1.png', N'daihatsu', N'grand_move', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (210, CAST(0x0000806800000000 AS DateTime), CAST(0x000081D500000000 AS DateTime), N'Hijet v1', N'http://cdn.carvalet.com/img/veh/daihatsu_hijet_1.png', N'daihatsu', N'hijet', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (211, CAST(0x0000861D00000000 AS DateTime), NULL, N'Materia v1', N'http://cdn.carvalet.com/img/veh/daihatsu_materia_1.png', N'daihatsu', N'materia', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (212, CAST(0x00008EAC00000000 AS DateTime), CAST(0x0000946100000000 AS DateTime), N'Sirion v1', N'http://cdn.carvalet.com/img/veh/daihatsu_sirion_1.png', N'daihatsu', N'sirion', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (213, CAST(0x00006DDC00000000 AS DateTime), CAST(0x0000739100000000 AS DateTime), N'Sportrak v1', N'http://cdn.carvalet.com/img/veh/daihatsu_sportrak_1.png', N'daihatsu', N'sportrak', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (214, CAST(0x000077D800000000 AS DateTime), CAST(0x00007AB300000000 AS DateTime), N'Terios v1', N'http://cdn.carvalet.com/img/veh/daihatsu_terios_1.png', N'daihatsu', N'terios', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (215, CAST(0x00007AB300000000 AS DateTime), NULL, N'Yrv v1', N'http://cdn.carvalet.com/img/veh/daihatsu_yrv_1.png', N'daihatsu', N'yrv', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (216, CAST(0x0000946100000000 AS DateTime), CAST(0x0000973C00000000 AS DateTime), N'Double Six v1', N'http://cdn.carvalet.com/img/veh/daimler_double_six_1.png', N'daimler', N'double_six', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (217, CAST(0x0000861D00000000 AS DateTime), NULL, N'Ds420 v1', N'http://cdn.carvalet.com/img/veh/daimler_ds420_1.png', N'daimler', N'ds420', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (218, CAST(0x000081D500000000 AS DateTime), CAST(0x000084B000000000 AS DateTime), N'Majestic v1', N'http://cdn.carvalet.com/img/veh/daimler_majestic_1.png', N'daimler', N'majestic', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (219, CAST(0x0000901A00000000 AS DateTime), CAST(0x0000946100000000 AS DateTime), N'Saloon v1', N'http://cdn.carvalet.com/img/veh/daimler_saloon_1.png', N'daimler', N'saloon', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (220, CAST(0x0000739100000000 AS DateTime), NULL, N'Series Iii v1', N'http://cdn.carvalet.com/img/veh/daimler_series_iii_1.png', N'daimler', N'series_iii', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (221, CAST(0x0000722300000000 AS DateTime), NULL, N'Six v1', N'http://cdn.carvalet.com/img/veh/daimler_six_1.png', N'daimler', N'six', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (222, CAST(0x0000973C00000000 AS DateTime), CAST(0x00009B8400000000 AS DateTime), N'Sovereign v1', N'http://cdn.carvalet.com/img/veh/daimler_sovereign_1.png', N'daimler', N'sovereign', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (223, CAST(0x000066B900000000 AS DateTime), CAST(0x0000682700000000 AS DateTime), N'Super V8 v1', N'http://cdn.carvalet.com/img/veh/daimler_super_v8_1.png', N'daimler', N'super_v8', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (224, CAST(0x000081D500000000 AS DateTime), CAST(0x000081D500000000 AS DateTime), N'V8 v1', N'http://cdn.carvalet.com/img/veh/daimler_v8_1.png', N'daimler', N'v8', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (225, CAST(0x0000861D00000000 AS DateTime), NULL, N'Vanden Plas v1', N'http://cdn.carvalet.com/img/veh/daimler_vanden_plas_1.png', N'daimler', N'vanden_plas', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (226, CAST(0x0000794600000000 AS DateTime), NULL, N'Xj Series v1', N'http://cdn.carvalet.com/img/veh/daimler_xj_series_1.png', N'daimler', N'xj_series', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (227, CAST(0x00007C2000000000 AS DateTime), NULL, N'Tojeiro v1', N'http://cdn.carvalet.com/img/veh/dax_tojeiro_1.png', N'dax', N'tojeiro', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (228, CAST(0x00006B0100000000 AS DateTime), NULL, N'Avenger v1', N'http://cdn.carvalet.com/img/veh/dodge_avenger_1.png', N'dodge', N'avenger', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (229, CAST(0x0000806800000000 AS DateTime), NULL, N'Caliber v1', N'http://cdn.carvalet.com/img/veh/dodge_caliber_1.png', N'dodge', N'caliber', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (230, CAST(0x0000739100000000 AS DateTime), NULL, N'Caravan v1', N'http://cdn.carvalet.com/img/veh/dodge_caravan_1.png', N'dodge', N'caravan', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (231, CAST(0x0000918700000000 AS DateTime), CAST(0x0000973C00000000 AS DateTime), N'Challenger v1', N'http://cdn.carvalet.com/img/veh/dodge_challenger_1.png', N'dodge', N'challenger', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (232, CAST(0x0000973C00000000 AS DateTime), CAST(0x00009CF100000000 AS DateTime), N'Dakota v1', N'http://cdn.carvalet.com/img/veh/dodge_dakota_1.png', N'dodge', N'dakota', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (233, CAST(0x00008EAC00000000 AS DateTime), CAST(0x00008EAC00000000 AS DateTime), N'Journey v1', N'http://cdn.carvalet.com/img/veh/dodge_journey_1.png', N'dodge', N'journey', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (234, CAST(0x00007C2000000000 AS DateTime), CAST(0x000081D500000000 AS DateTime), N'Nitro v1', N'http://cdn.carvalet.com/img/veh/dodge_nitro_1.png', N'dodge', N'nitro', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (235, CAST(0x00008EAC00000000 AS DateTime), NULL, N'Ram v1', N'http://cdn.carvalet.com/img/veh/dodge_ram_1.png', N'dodge', N'ram', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (236, CAST(0x0000739100000000 AS DateTime), NULL, N'Srt-10 v1', N'http://cdn.carvalet.com/img/veh/dodge_srt-10_1.png', N'dodge', N'srt-10', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (237, CAST(0x0000766B00000000 AS DateTime), NULL, N'Series Ii v1', N'http://cdn.carvalet.com/img/veh/excalibur_series_ii_1.png', N'excalibur', N'series_ii', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (238, CAST(0x00006F4900000000 AS DateTime), NULL, N'250 v1', N'http://cdn.carvalet.com/img/veh/ferrari_250_1.png', N'ferrari', N'250', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (239, CAST(0x00006DDC00000000 AS DateTime), CAST(0x0000739100000000 AS DateTime), N'275 v1', N'http://cdn.carvalet.com/img/veh/ferrari_275_1.png', N'ferrari', N'275', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (240, CAST(0x0000834200000000 AS DateTime), NULL, N'308 v1', N'http://cdn.carvalet.com/img/veh/ferrari_308_1.png', N'ferrari', N'308', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (241, CAST(0x000081D500000000 AS DateTime), CAST(0x000081D500000000 AS DateTime), N'328 v1', N'http://cdn.carvalet.com/img/veh/ferrari_328_1.png', N'ferrari', N'328', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (242, CAST(0x0000878A00000000 AS DateTime), NULL, N'330 v1', N'http://cdn.carvalet.com/img/veh/ferrari_330_1.png', N'ferrari', N'330', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (243, CAST(0x00008D3F00000000 AS DateTime), NULL, N'348 v1', N'http://cdn.carvalet.com/img/veh/ferrari_348_1.png', N'ferrari', N'348', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (244, CAST(0x0000973C00000000 AS DateTime), CAST(0x0000973C00000000 AS DateTime), N'360 v1', N'http://cdn.carvalet.com/img/veh/ferrari_360_1.png', N'ferrari', N'360', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (245, CAST(0x000070B600000000 AS DateTime), CAST(0x000070B600000000 AS DateTime), N'412 v1', N'http://cdn.carvalet.com/img/veh/ferrari_412_1.png', N'ferrari', N'412', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (246, CAST(0x00006C6E00000000 AS DateTime), CAST(0x000070B600000000 AS DateTime), N'456 v1', N'http://cdn.carvalet.com/img/veh/ferrari_456_1.png', N'ferrari', N'456', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (247, CAST(0x0000861D00000000 AS DateTime), NULL, N'458 v1', N'http://cdn.carvalet.com/img/veh/ferrari_458_1.png', N'ferrari', N'458', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (248, CAST(0x00006DDC00000000 AS DateTime), NULL, N'512 v1', N'http://cdn.carvalet.com/img/veh/ferrari_512_1.png', N'ferrari', N'512', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (249, CAST(0x00007D8D00000000 AS DateTime), CAST(0x0000806800000000 AS DateTime), N'550 v1', N'http://cdn.carvalet.com/img/veh/ferrari_550_1.png', N'ferrari', N'550', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (250, CAST(0x0000794600000000 AS DateTime), CAST(0x00007EFB00000000 AS DateTime), N'575M v1', N'http://cdn.carvalet.com/img/veh/ferrari_575m_1.png', N'ferrari', N'575m', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (251, CAST(0x00008A6500000000 AS DateTime), NULL, N'599 v1', N'http://cdn.carvalet.com/img/veh/ferrari_599_1.png', N'ferrari', N'599', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (252, CAST(0x0000973C00000000 AS DateTime), CAST(0x00009A1600000000 AS DateTime), N'612 v1', N'http://cdn.carvalet.com/img/veh/ferrari_612_1.png', N'ferrari', N'612', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (253, CAST(0x0000901A00000000 AS DateTime), NULL, N'California v1', N'http://cdn.carvalet.com/img/veh/ferrari_california_1.png', N'ferrari', N'california', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (254, CAST(0x00008EAC00000000 AS DateTime), NULL, N'Enzo v1', N'http://cdn.carvalet.com/img/veh/ferrari_enzo_1.png', N'ferrari', N'enzo', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (255, CAST(0x000092F400000000 AS DateTime), CAST(0x0000973C00000000 AS DateTime), N'F355 v1', N'http://cdn.carvalet.com/img/veh/ferrari_f355_1.png', N'ferrari', N'f355', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (256, CAST(0x000077D800000000 AS DateTime), CAST(0x00007AB300000000 AS DateTime), N'F40 v1', N'http://cdn.carvalet.com/img/veh/ferrari_f40_1.png', N'ferrari', N'f40', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (257, CAST(0x0000973C00000000 AS DateTime), CAST(0x00009CF100000000 AS DateTime), N'F430 v1', N'http://cdn.carvalet.com/img/veh/ferrari_f430_1.png', N'ferrari', N'f430', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (258, CAST(0x0000654C00000000 AS DateTime), CAST(0x000066B900000000 AS DateTime), N'F50 v1', N'http://cdn.carvalet.com/img/veh/ferrari_f50_1.png', N'ferrari', N'f50', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (259, CAST(0x000084B000000000 AS DateTime), NULL, N'Ff v1', N'http://cdn.carvalet.com/img/veh/ferrari_ff_1.png', N'ferrari', N'ff', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (260, CAST(0x0000834200000000 AS DateTime), CAST(0x000084B000000000 AS DateTime), N'Mondial v1', N'http://cdn.carvalet.com/img/veh/ferrari_mondial_1.png', N'ferrari', N'mondial', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (261, CAST(0x00008D3F00000000 AS DateTime), CAST(0x0000918700000000 AS DateTime), N'Testarossa v1', N'http://cdn.carvalet.com/img/veh/ferrari_testarossa_1.png', N'ferrari', N'testarossa', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (262, CAST(0x00008A6500000000 AS DateTime), CAST(0x00008EAC00000000 AS DateTime), N'1100 v1', N'http://cdn.carvalet.com/img/veh/fiat_1100_1.png', N'fiat', N'1100', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (263, CAST(0x00008A6500000000 AS DateTime), NULL, N'124 v1', N'http://cdn.carvalet.com/img/veh/fiat_124_1.png', N'fiat', N'124', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (264, CAST(0x0000654C00000000 AS DateTime), CAST(0x00006B0100000000 AS DateTime), N'2300 v1', N'http://cdn.carvalet.com/img/veh/fiat_2300_1.png', N'fiat', N'2300', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (265, CAST(0x00006C6E00000000 AS DateTime), NULL, N'500 v1', N'http://cdn.carvalet.com/img/veh/fiat_500_1.png', N'fiat', N'500', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (266, CAST(0x00007AB300000000 AS DateTime), NULL, N'Abarth v1', N'http://cdn.carvalet.com/img/veh/fiat_abarth_1.png', N'fiat', N'abarth', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (267, CAST(0x0000739100000000 AS DateTime), CAST(0x0000766B00000000 AS DateTime), N'Barchetta v1', N'http://cdn.carvalet.com/img/veh/fiat_barchetta_1.png', N'fiat', N'barchetta', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (268, CAST(0x000066B900000000 AS DateTime), CAST(0x00006B0100000000 AS DateTime), N'Brava v1', N'http://cdn.carvalet.com/img/veh/fiat_brava_1.png', N'fiat', N'brava', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (269, CAST(0x0000806800000000 AS DateTime), CAST(0x0000834200000000 AS DateTime), N'Bravo v1', N'http://cdn.carvalet.com/img/veh/fiat_bravo_1.png', N'fiat', N'bravo', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (270, CAST(0x000077D800000000 AS DateTime), NULL, N'Cinquecento v1', N'http://cdn.carvalet.com/img/veh/fiat_cinquecento_1.png', N'fiat', N'cinquecento', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (271, CAST(0x000077D800000000 AS DateTime), CAST(0x00007AB300000000 AS DateTime), N'Coupe v1', N'http://cdn.carvalet.com/img/veh/fiat_coupe_1.png', N'fiat', N'coupe', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (272, CAST(0x0000699400000000 AS DateTime), NULL, N'Croma v1', N'http://cdn.carvalet.com/img/veh/fiat_croma_1.png', N'fiat', N'croma', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (273, CAST(0x000077D800000000 AS DateTime), NULL, N'Doblo v1', N'http://cdn.carvalet.com/img/veh/fiat_doblo_1.png', N'fiat', N'doblo', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (274, CAST(0x00006C6E00000000 AS DateTime), NULL, N'Ducato v1', N'http://cdn.carvalet.com/img/veh/fiat_ducato_1.png', N'fiat', N'ducato', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (275, CAST(0x000098A900000000 AS DateTime), CAST(0x000098A900000000 AS DateTime), N'Fiorino v1', N'http://cdn.carvalet.com/img/veh/fiat_fiorino_1.png', N'fiat', N'fiorino', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (276, CAST(0x00007D8D00000000 AS DateTime), NULL, N'Grande Punto v1', N'http://cdn.carvalet.com/img/veh/fiat_grande_punto_1.png', N'fiat', N'grande_punto', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (277, CAST(0x0000946100000000 AS DateTime), CAST(0x000098A900000000 AS DateTime), N'Idea v1', N'http://cdn.carvalet.com/img/veh/fiat_idea_1.png', N'fiat', N'idea', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (278, CAST(0x00007EFB00000000 AS DateTime), CAST(0x0000806800000000 AS DateTime), N'Marea v1', N'http://cdn.carvalet.com/img/veh/fiat_marea_1.png', N'fiat', N'marea', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (279, CAST(0x00006C6E00000000 AS DateTime), CAST(0x00006F4900000000 AS DateTime), N'Multipla v1', N'http://cdn.carvalet.com/img/veh/fiat_multipla_1.png', N'fiat', N'multipla', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (280, CAST(0x0000973C00000000 AS DateTime), NULL, N'Panda v1', N'http://cdn.carvalet.com/img/veh/fiat_panda_1.png', N'fiat', N'panda', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (281, CAST(0x00006C6E00000000 AS DateTime), CAST(0x00006F4900000000 AS DateTime), N'Punto v1', N'http://cdn.carvalet.com/img/veh/fiat_punto_1.png', N'fiat', N'punto', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (282, CAST(0x000081D500000000 AS DateTime), CAST(0x000084B000000000 AS DateTime), N'Punto Evo v1', N'http://cdn.carvalet.com/img/veh/fiat_punto_evo_1.png', N'fiat', N'punto_evo', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (283, CAST(0x00006C6E00000000 AS DateTime), NULL, N'Qubo v1', N'http://cdn.carvalet.com/img/veh/fiat_qubo_1.png', N'fiat', N'qubo', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (284, CAST(0x000084B000000000 AS DateTime), CAST(0x000084B000000000 AS DateTime), N'Scudo v1', N'http://cdn.carvalet.com/img/veh/fiat_scudo_1.png', N'fiat', N'scudo', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (285, CAST(0x0000722300000000 AS DateTime), CAST(0x0000722300000000 AS DateTime), N'Scudo Combi v1', N'http://cdn.carvalet.com/img/veh/fiat_scudo_combi_1.png', N'fiat', N'scudo_combi', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (286, CAST(0x0000834200000000 AS DateTime), CAST(0x0000861D00000000 AS DateTime), N'Scudo Panorama v1', N'http://cdn.carvalet.com/img/veh/fiat_scudo_panorama_1.png', N'fiat', N'scudo_panorama', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (287, CAST(0x0000766B00000000 AS DateTime), CAST(0x0000766B00000000 AS DateTime), N'Sedici v1', N'http://cdn.carvalet.com/img/veh/fiat_sedici_1.png', N'fiat', N'sedici', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (288, CAST(0x00006B0100000000 AS DateTime), NULL, N'Seicento v1', N'http://cdn.carvalet.com/img/veh/fiat_seicento_1.png', N'fiat', N'seicento', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (289, CAST(0x0000699400000000 AS DateTime), NULL, N'Stilo v1', N'http://cdn.carvalet.com/img/veh/fiat_stilo_1.png', N'fiat', N'stilo', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (290, CAST(0x00006C6E00000000 AS DateTime), CAST(0x00006DDC00000000 AS DateTime), N'Tipo v1', N'http://cdn.carvalet.com/img/veh/fiat_tipo_1.png', N'fiat', N'tipo', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (291, CAST(0x00007EFB00000000 AS DateTime), CAST(0x000081D500000000 AS DateTime), N'Ulysse v1', N'http://cdn.carvalet.com/img/veh/fiat_ulysse_1.png', N'fiat', N'ulysse', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (292, CAST(0x00008D3F00000000 AS DateTime), CAST(0x0000901A00000000 AS DateTime), N'X19 v1', N'http://cdn.carvalet.com/img/veh/fiat_x19_1.png', N'fiat', N'x19', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (293, CAST(0x00008D3F00000000 AS DateTime), CAST(0x000092F400000000 AS DateTime), N'Anglia v1', N'http://cdn.carvalet.com/img/veh/ford_anglia_1.png', N'ford', N'anglia', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (294, CAST(0x000063DF00000000 AS DateTime), NULL, N'Capri v1', N'http://cdn.carvalet.com/img/veh/ford_capri_1.png', N'ford', N'capri', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (295, CAST(0x00008EAC00000000 AS DateTime), NULL, N'C-Max v1', N'http://cdn.carvalet.com/img/veh/ford_c-max_1.png', N'ford', N'c-max', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (296, CAST(0x000095CF00000000 AS DateTime), CAST(0x00009B8400000000 AS DateTime), N'Cortina v1', N'http://cdn.carvalet.com/img/veh/ford_cortina_1.png', N'ford', N'cortina', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (297, CAST(0x0000861D00000000 AS DateTime), CAST(0x0000878A00000000 AS DateTime), N'Cougar v1', N'http://cdn.carvalet.com/img/veh/ford_cougar_1.png', N'ford', N'cougar', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (298, CAST(0x000088F700000000 AS DateTime), CAST(0x00008A6500000000 AS DateTime), N'Crown Victoria v1', N'http://cdn.carvalet.com/img/veh/ford_crown_victoria_1.png', N'ford', N'crown_victoria', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (299, CAST(0x00008A6500000000 AS DateTime), NULL, N'Dorchester v1', N'http://cdn.carvalet.com/img/veh/ford_dorchester_1.png', N'ford', N'dorchester', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (300, CAST(0x000070B600000000 AS DateTime), NULL, N'Escort v1', N'http://cdn.carvalet.com/img/veh/ford_escort_1.png', N'ford', N'escort', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (301, CAST(0x00008EAC00000000 AS DateTime), NULL, N'Expedition v1', N'http://cdn.carvalet.com/img/veh/ford_expedition_1.png', N'ford', N'expedition', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (302, CAST(0x000066B900000000 AS DateTime), CAST(0x0000699400000000 AS DateTime), N'Explorer v1', N'http://cdn.carvalet.com/img/veh/ford_explorer_1.png', N'ford', N'explorer', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (303, CAST(0x000077D800000000 AS DateTime), NULL, N'F150 v1', N'http://cdn.carvalet.com/img/veh/ford_f150_1.png', N'ford', N'f150', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (304, CAST(0x00006C6E00000000 AS DateTime), NULL, N'F250 v1', N'http://cdn.carvalet.com/img/veh/ford_f250_1.png', N'ford', N'f250', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (305, CAST(0x0000722300000000 AS DateTime), CAST(0x000074FE00000000 AS DateTime), N'Falcon v1', N'http://cdn.carvalet.com/img/veh/ford_falcon_1.png', N'ford', N'falcon', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (306, CAST(0x000098A900000000 AS DateTime), NULL, N'Fiesta v1', N'http://cdn.carvalet.com/img/veh/ford_fiesta_1.png', N'ford', N'fiesta', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (307, CAST(0x00006B0100000000 AS DateTime), NULL, N'Flex v1', N'http://cdn.carvalet.com/img/veh/ford_flex_1.png', N'ford', N'flex', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (308, CAST(0x00008A6500000000 AS DateTime), CAST(0x0000901A00000000 AS DateTime), N'Focus v1', N'http://cdn.carvalet.com/img/veh/ford_focus_1.png', N'ford', N'focus', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (309, CAST(0x000081D500000000 AS DateTime), NULL, N'Focus C-Max v1', N'http://cdn.carvalet.com/img/veh/ford_focus_c-max_1.png', N'ford', N'focus_c-max', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (310, CAST(0x00006F4900000000 AS DateTime), NULL, N'Freda v1', N'http://cdn.carvalet.com/img/veh/ford_freda_1.png', N'ford', N'freda', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (311, CAST(0x000070B600000000 AS DateTime), CAST(0x0000722300000000 AS DateTime), N'Fusion v1', N'http://cdn.carvalet.com/img/veh/ford_fusion_1.png', N'ford', N'fusion', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (312, CAST(0x000095CF00000000 AS DateTime), NULL, N'Galaxy v1', N'http://cdn.carvalet.com/img/veh/ford_galaxy_1.png', N'ford', N'galaxy', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (313, CAST(0x0000973C00000000 AS DateTime), NULL, N'Granada v1', N'http://cdn.carvalet.com/img/veh/ford_granada_1.png', N'ford', N'granada', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (314, CAST(0x0000766B00000000 AS DateTime), CAST(0x0000794600000000 AS DateTime), N'Grand C-Max v1', N'http://cdn.carvalet.com/img/veh/ford_grand_c-max_1.png', N'ford', N'grand_c-max', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (315, CAST(0x0000722300000000 AS DateTime), CAST(0x000074FE00000000 AS DateTime), N'Gt v1', N'http://cdn.carvalet.com/img/veh/ford_gt_1.png', N'ford', N'gt', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (316, CAST(0x0000861D00000000 AS DateTime), CAST(0x000088F700000000 AS DateTime), N'Ka v1', N'http://cdn.carvalet.com/img/veh/ford_ka_1.png', N'ford', N'ka', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (317, CAST(0x00006DDC00000000 AS DateTime), NULL, N'Kuga v1', N'http://cdn.carvalet.com/img/veh/ford_kuga_1.png', N'ford', N'kuga', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (318, CAST(0x0000766B00000000 AS DateTime), CAST(0x0000794600000000 AS DateTime), N'Maverick v1', N'http://cdn.carvalet.com/img/veh/ford_maverick_1.png', N'ford', N'maverick', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (319, CAST(0x0000901A00000000 AS DateTime), NULL, N'Model A v1', N'http://cdn.carvalet.com/img/veh/ford_model_a_1.png', N'ford', N'model_a', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (320, CAST(0x0000901A00000000 AS DateTime), CAST(0x000092F400000000 AS DateTime), N'Model T v1', N'http://cdn.carvalet.com/img/veh/ford_model_t_1.png', N'ford', N'model_t', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (321, CAST(0x0000901A00000000 AS DateTime), CAST(0x0000901A00000000 AS DateTime), N'Mondeo v1', N'http://cdn.carvalet.com/img/veh/ford_mondeo_1.png', N'ford', N'mondeo', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (322, CAST(0x000092F400000000 AS DateTime), CAST(0x0000973C00000000 AS DateTime), N'Mustang v1', N'http://cdn.carvalet.com/img/veh/ford_mustang_1.png', N'ford', N'mustang', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (323, CAST(0x000081D500000000 AS DateTime), NULL, N'Orion v1', N'http://cdn.carvalet.com/img/veh/ford_orion_1.png', N'ford', N'orion', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (324, CAST(0x0000901A00000000 AS DateTime), NULL, N'Prefect v1', N'http://cdn.carvalet.com/img/veh/ford_prefect_1.png', N'ford', N'prefect', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (325, CAST(0x000070B600000000 AS DateTime), CAST(0x000070B600000000 AS DateTime), N'Probe v1', N'http://cdn.carvalet.com/img/veh/ford_probe_1.png', N'ford', N'probe', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (326, CAST(0x00006F4900000000 AS DateTime), CAST(0x000074FE00000000 AS DateTime), N'Puma v1', N'http://cdn.carvalet.com/img/veh/ford_puma_1.png', N'ford', N'puma', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (327, CAST(0x00006C6E00000000 AS DateTime), CAST(0x000070B600000000 AS DateTime), N'Ranger v1', N'http://cdn.carvalet.com/img/veh/ford_ranger_1.png', N'ford', N'ranger', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (328, CAST(0x000095CF00000000 AS DateTime), CAST(0x00009B8400000000 AS DateTime), N'Rs200 v1', N'http://cdn.carvalet.com/img/veh/ford_rs200_1.png', N'ford', N'rs200', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (329, CAST(0x000070B600000000 AS DateTime), NULL, N'Scorpio v1', N'http://cdn.carvalet.com/img/veh/ford_scorpio_1.png', N'ford', N'scorpio', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (330, CAST(0x0000861D00000000 AS DateTime), NULL, N'Sherrod v1', N'http://cdn.carvalet.com/img/veh/ford_sherrod_1.png', N'ford', N'sherrod', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (331, CAST(0x0000918700000000 AS DateTime), CAST(0x0000973C00000000 AS DateTime), N'Sierra v1', N'http://cdn.carvalet.com/img/veh/ford_sierra_1.png', N'ford', N'sierra', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (332, CAST(0x00007AB300000000 AS DateTime), NULL, N'S-Max v1', N'http://cdn.carvalet.com/img/veh/ford_s-max_1.png', N'ford', N's-max', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (333, CAST(0x0000794600000000 AS DateTime), NULL, N'Streetka v1', N'http://cdn.carvalet.com/img/veh/ford_streetka_1.png', N'ford', N'streetka', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (334, CAST(0x0000861D00000000 AS DateTime), NULL, N'Thunderbird v1', N'http://cdn.carvalet.com/img/veh/ford_thunderbird_1.png', N'ford', N'thunderbird', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (335, CAST(0x00007C2000000000 AS DateTime), NULL, N'Transit Torneo v1', N'http://cdn.carvalet.com/img/veh/ford_transit_torneo_1.png', N'ford', N'transit_torneo', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (336, CAST(0x0000973C00000000 AS DateTime), NULL, N'Yukon v1', N'http://cdn.carvalet.com/img/veh/gmc_yukon_1.png', N'gmc', N'yukon', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (337, CAST(0x000088F700000000 AS DateTime), CAST(0x00008D3F00000000 AS DateTime), N'Steed v1', N'http://cdn.carvalet.com/img/veh/great_wall_steed_1.png', N'great_wall', N'steed', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (338, CAST(0x0000901A00000000 AS DateTime), CAST(0x0000918700000000 AS DateTime), N'Apollo v1', N'http://cdn.carvalet.com/img/veh/gumpert_apollo_1.png', N'gumpert', N'apollo', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (339, CAST(0x00008BD200000000 AS DateTime), NULL, N'Hsv v1', N'http://cdn.carvalet.com/img/veh/holden_hsv_1.png', N'holden', N'hsv', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (340, CAST(0x00006B0100000000 AS DateTime), NULL, N'Accord v1', N'http://cdn.carvalet.com/img/veh/honda_accord_1.png', N'honda', N'accord', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (341, CAST(0x000081D500000000 AS DateTime), NULL, N'Aerodeck v1', N'http://cdn.carvalet.com/img/veh/honda_aerodeck_1.png', N'honda', N'aerodeck', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (342, CAST(0x0000682700000000 AS DateTime), NULL, N'Beat v1', N'http://cdn.carvalet.com/img/veh/honda_beat_1.png', N'honda', N'beat', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (343, CAST(0x000084B000000000 AS DateTime), NULL, N'Civic v1', N'http://cdn.carvalet.com/img/veh/honda_civic_1.png', N'honda', N'civic', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (344, CAST(0x000098A900000000 AS DateTime), CAST(0x000098A900000000 AS DateTime), N'Cr-V v1', N'http://cdn.carvalet.com/img/veh/honda_cr-v_1.png', N'honda', N'cr-v', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (345, CAST(0x000070B600000000 AS DateTime), NULL, N'Cr-X v1', N'http://cdn.carvalet.com/img/veh/honda_cr-x_1.png', N'honda', N'cr-x', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (346, CAST(0x00008BD200000000 AS DateTime), NULL, N'Cr-Z v1', N'http://cdn.carvalet.com/img/veh/honda_cr-z_1.png', N'honda', N'cr-z', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (347, CAST(0x0000973C00000000 AS DateTime), CAST(0x00009A1600000000 AS DateTime), N'Fr-V v1', N'http://cdn.carvalet.com/img/veh/honda_fr-v_1.png', N'honda', N'fr-v', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (348, CAST(0x0000901A00000000 AS DateTime), NULL, N'Hr-V v1', N'http://cdn.carvalet.com/img/veh/honda_hr-v_1.png', N'honda', N'hr-v', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (349, CAST(0x0000806800000000 AS DateTime), CAST(0x0000806800000000 AS DateTime), N'Insight v1', N'http://cdn.carvalet.com/img/veh/honda_insight_1.png', N'honda', N'insight', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (350, CAST(0x00008BD200000000 AS DateTime), CAST(0x00008BD200000000 AS DateTime), N'Integra v1', N'http://cdn.carvalet.com/img/veh/honda_integra_1.png', N'honda', N'integra', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (351, CAST(0x000063DF00000000 AS DateTime), CAST(0x0000682700000000 AS DateTime), N'Jazz v1', N'http://cdn.carvalet.com/img/veh/honda_jazz_1.png', N'honda', N'jazz', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (352, CAST(0x000063DF00000000 AS DateTime), NULL, N'Legend v1', N'http://cdn.carvalet.com/img/veh/honda_legend_1.png', N'honda', N'legend', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (353, CAST(0x00008BD200000000 AS DateTime), NULL, N'Logo v1', N'http://cdn.carvalet.com/img/veh/honda_logo_1.png', N'honda', N'logo', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (354, CAST(0x000092F400000000 AS DateTime), NULL, N'Nsx v1', N'http://cdn.carvalet.com/img/veh/honda_nsx_1.png', N'honda', N'nsx', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (355, CAST(0x00006DDC00000000 AS DateTime), NULL, N'Odyssey v1', N'http://cdn.carvalet.com/img/veh/honda_odyssey_1.png', N'honda', N'odyssey', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (356, CAST(0x00008D3F00000000 AS DateTime), CAST(0x00008EAC00000000 AS DateTime), N'Prelude v1', N'http://cdn.carvalet.com/img/veh/honda_prelude_1.png', N'honda', N'prelude', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (357, CAST(0x00008BD200000000 AS DateTime), CAST(0x00008BD200000000 AS DateTime), N'S2000 v1', N'http://cdn.carvalet.com/img/veh/honda_s2000_1.png', N'honda', N's2000', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (358, CAST(0x000063DF00000000 AS DateTime), NULL, N'Shuttle v1', N'http://cdn.carvalet.com/img/veh/honda_shuttle_1.png', N'honda', N'shuttle', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (359, CAST(0x00008A6500000000 AS DateTime), CAST(0x0000901A00000000 AS DateTime), N'S-Mx v1', N'http://cdn.carvalet.com/img/veh/honda_s-mx_1.png', N'honda', N's-mx', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (360, CAST(0x0000861D00000000 AS DateTime), CAST(0x000088F700000000 AS DateTime), N'Stepwagon v1', N'http://cdn.carvalet.com/img/veh/honda_stepwagon_1.png', N'honda', N'stepwagon', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (361, CAST(0x0000654C00000000 AS DateTime), NULL, N'Stream v1', N'http://cdn.carvalet.com/img/veh/honda_stream_1.png', N'honda', N'stream', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (362, CAST(0x0000861D00000000 AS DateTime), NULL, N'Sceptre v1', N'http://cdn.carvalet.com/img/veh/humber_sceptre_1.png', N'humber', N'sceptre', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (363, CAST(0x0000654C00000000 AS DateTime), NULL, N'H1 v1', N'http://cdn.carvalet.com/img/veh/hummer_h1_1.png', N'hummer', N'h1', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (364, CAST(0x0000901A00000000 AS DateTime), NULL, N'H2 v1', N'http://cdn.carvalet.com/img/veh/hummer_h2_1.png', N'hummer', N'h2', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (365, CAST(0x000095CF00000000 AS DateTime), CAST(0x00009B8400000000 AS DateTime), N'H3 v1', N'http://cdn.carvalet.com/img/veh/hummer_h3_1.png', N'hummer', N'h3', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (366, CAST(0x00006F4900000000 AS DateTime), NULL, N'Accent v1', N'http://cdn.carvalet.com/img/veh/hyundai_accent_1.png', N'hyundai', N'accent', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (367, CAST(0x00008BD200000000 AS DateTime), CAST(0x00008D3F00000000 AS DateTime), N'Amica v1', N'http://cdn.carvalet.com/img/veh/hyundai_amica_1.png', N'hyundai', N'amica', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (368, CAST(0x0000878A00000000 AS DateTime), CAST(0x00008A6500000000 AS DateTime), N'Atoz v1', N'http://cdn.carvalet.com/img/veh/hyundai_atoz_1.png', N'hyundai', N'atoz', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (369, CAST(0x0000878A00000000 AS DateTime), CAST(0x000088F700000000 AS DateTime), N'Coupe v1', N'http://cdn.carvalet.com/img/veh/hyundai_coupe_1.png', N'hyundai', N'coupe', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (370, CAST(0x0000806800000000 AS DateTime), NULL, N'Elantra v1', N'http://cdn.carvalet.com/img/veh/hyundai_elantra_1.png', N'hyundai', N'elantra', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (371, CAST(0x000092F400000000 AS DateTime), CAST(0x000092F400000000 AS DateTime), N'Getz v1', N'http://cdn.carvalet.com/img/veh/hyundai_getz_1.png', N'hyundai', N'getz', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (372, CAST(0x00008A6500000000 AS DateTime), CAST(0x0000901A00000000 AS DateTime), N'Grandeur v1', N'http://cdn.carvalet.com/img/veh/hyundai_grandeur_1.png', N'hyundai', N'grandeur', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (373, CAST(0x0000682700000000 AS DateTime), CAST(0x00006DDC00000000 AS DateTime), N'I10 v1', N'http://cdn.carvalet.com/img/veh/hyundai_i10_1.png', N'hyundai', N'i10', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (374, CAST(0x0000834200000000 AS DateTime), NULL, N'I20 v1', N'http://cdn.carvalet.com/img/veh/hyundai_i20_1.png', N'hyundai', N'i20', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (375, CAST(0x0000739100000000 AS DateTime), CAST(0x0000739100000000 AS DateTime), N'I30 v1', N'http://cdn.carvalet.com/img/veh/hyundai_i30_1.png', N'hyundai', N'i30', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (376, CAST(0x000088F700000000 AS DateTime), NULL, N'I40 v1', N'http://cdn.carvalet.com/img/veh/hyundai_i40_1.png', N'hyundai', N'i40', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (377, CAST(0x00007C2000000000 AS DateTime), CAST(0x00007D8D00000000 AS DateTime), N'I800 v1', N'http://cdn.carvalet.com/img/veh/hyundai_i800_1.png', N'hyundai', N'i800', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (378, CAST(0x00006C6E00000000 AS DateTime), CAST(0x00006F4900000000 AS DateTime), N'Ix20 v1', N'http://cdn.carvalet.com/img/veh/hyundai_ix20_1.png', N'hyundai', N'ix20', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (379, CAST(0x00006B0100000000 AS DateTime), NULL, N'Ix35 v1', N'http://cdn.carvalet.com/img/veh/hyundai_ix35_1.png', N'hyundai', N'ix35', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (380, CAST(0x0000834200000000 AS DateTime), CAST(0x0000878A00000000 AS DateTime), N'Lantra v1', N'http://cdn.carvalet.com/img/veh/hyundai_lantra_1.png', N'hyundai', N'lantra', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (381, CAST(0x0000946100000000 AS DateTime), CAST(0x0000946100000000 AS DateTime), N'Matrix v1', N'http://cdn.carvalet.com/img/veh/hyundai_matrix_1.png', N'hyundai', N'matrix', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (382, CAST(0x00008EAC00000000 AS DateTime), NULL, N'Santa Fe v1', N'http://cdn.carvalet.com/img/veh/hyundai_santa_fe_1.png', N'hyundai', N'santa_fe', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (383, CAST(0x0000946100000000 AS DateTime), CAST(0x00009A1600000000 AS DateTime), N'S-Coupe v1', N'http://cdn.carvalet.com/img/veh/hyundai_s-coupe_1.png', N'hyundai', N's-coupe', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (384, CAST(0x0000654C00000000 AS DateTime), NULL, N'Sonata v1', N'http://cdn.carvalet.com/img/veh/hyundai_sonata_1.png', N'hyundai', N'sonata', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (385, CAST(0x0000682700000000 AS DateTime), CAST(0x0000682700000000 AS DateTime), N'Terracan v1', N'http://cdn.carvalet.com/img/veh/hyundai_terracan_1.png', N'hyundai', N'terracan', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (386, CAST(0x0000654C00000000 AS DateTime), CAST(0x000066B900000000 AS DateTime), N'Trajet v1', N'http://cdn.carvalet.com/img/veh/hyundai_trajet_1.png', N'hyundai', N'trajet', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (387, CAST(0x0000794600000000 AS DateTime), NULL, N'Tucson v1', N'http://cdn.carvalet.com/img/veh/hyundai_tucson_1.png', N'hyundai', N'tucson', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (388, CAST(0x0000699400000000 AS DateTime), NULL, N'Veloster v1', N'http://cdn.carvalet.com/img/veh/hyundai_veloster_1.png', N'hyundai', N'veloster', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (389, CAST(0x00007EFB00000000 AS DateTime), NULL, N'Xg30 v1', N'http://cdn.carvalet.com/img/veh/hyundai_xg30_1.png', N'hyundai', N'xg30', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (390, CAST(0x000092F400000000 AS DateTime), CAST(0x0000946100000000 AS DateTime), N'Ex v1', N'http://cdn.carvalet.com/img/veh/infiniti_ex_1.png', N'infiniti', N'ex', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (391, CAST(0x0000918700000000 AS DateTime), NULL, N'Ex37 v1', N'http://cdn.carvalet.com/img/veh/infiniti_ex37_1.png', N'infiniti', N'ex37', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (392, CAST(0x0000806800000000 AS DateTime), CAST(0x0000861D00000000 AS DateTime), N'Fx v1', N'http://cdn.carvalet.com/img/veh/infiniti_fx_1.png', N'infiniti', N'fx', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (393, CAST(0x00008EAC00000000 AS DateTime), CAST(0x00008EAC00000000 AS DateTime), N'G37 v1', N'http://cdn.carvalet.com/img/veh/infiniti_g37_1.png', N'infiniti', N'g37', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (394, CAST(0x00006B0100000000 AS DateTime), NULL, N'M v1', N'http://cdn.carvalet.com/img/veh/infiniti_m_1.png', N'infiniti', N'm', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (395, CAST(0x0000901A00000000 AS DateTime), CAST(0x0000946100000000 AS DateTime), N'Bighorn v1', N'http://cdn.carvalet.com/img/veh/isuzu_bighorn_1.png', N'isuzu', N'bighorn', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (396, CAST(0x00008EAC00000000 AS DateTime), NULL, N'D-Max v1', N'http://cdn.carvalet.com/img/veh/isuzu_d-max_1.png', N'isuzu', N'd-max', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (397, CAST(0x000095CF00000000 AS DateTime), NULL, N'Rodeo v1', N'http://cdn.carvalet.com/img/veh/isuzu_rodeo_1.png', N'isuzu', N'rodeo', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (398, CAST(0x0000861D00000000 AS DateTime), NULL, N'Tf v1', N'http://cdn.carvalet.com/img/veh/isuzu_tf_1.png', N'isuzu', N'tf', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (399, CAST(0x000077D800000000 AS DateTime), NULL, N'Trooper v1', N'http://cdn.carvalet.com/img/veh/isuzu_trooper_1.png', N'isuzu', N'trooper', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (400, CAST(0x00006F4900000000 AS DateTime), CAST(0x000074FE00000000 AS DateTime), N'E-Type v1', N'http://cdn.carvalet.com/img/veh/jaguar_e-type_1.png', N'jaguar', N'e-type', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (401, CAST(0x00006C6E00000000 AS DateTime), CAST(0x00006C6E00000000 AS DateTime), N'Mark Ii v1', N'http://cdn.carvalet.com/img/veh/jaguar_mark_ii_1.png', N'jaguar', N'mark_ii', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (402, CAST(0x00007D8D00000000 AS DateTime), NULL, N'Sovereign v1', N'http://cdn.carvalet.com/img/veh/jaguar_sovereign_1.png', N'jaguar', N'sovereign', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (403, CAST(0x00006B0100000000 AS DateTime), CAST(0x00006C6E00000000 AS DateTime), N'S-Type v1', N'http://cdn.carvalet.com/img/veh/jaguar_s-type_1.png', N'jaguar', N's-type', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (404, CAST(0x000095CF00000000 AS DateTime), NULL, N'Xf v1', N'http://cdn.carvalet.com/img/veh/jaguar_xf_1.png', N'jaguar', N'xf', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (405, CAST(0x0000973C00000000 AS DateTime), NULL, N'Xj v1', N'http://cdn.carvalet.com/img/veh/jaguar_xj_1.png', N'jaguar', N'xj', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (406, CAST(0x00008D3F00000000 AS DateTime), CAST(0x00008EAC00000000 AS DateTime), N'Xjs v1', N'http://cdn.carvalet.com/img/veh/jaguar_xjs_1.png', N'jaguar', N'xjs', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (407, CAST(0x0000901A00000000 AS DateTime), NULL, N'Xk v1', N'http://cdn.carvalet.com/img/veh/jaguar_xk_1.png', N'jaguar', N'xk', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (408, CAST(0x0000901A00000000 AS DateTime), NULL, N'X-Type v1', N'http://cdn.carvalet.com/img/veh/jaguar_x-type_1.png', N'jaguar', N'x-type', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (409, CAST(0x0000918700000000 AS DateTime), NULL, N'Cherokee v1', N'http://cdn.carvalet.com/img/veh/jeep_cherokee_1.png', N'jeep', N'cherokee', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (410, CAST(0x00007AB300000000 AS DateTime), CAST(0x00007C2000000000 AS DateTime), N'Commander v1', N'http://cdn.carvalet.com/img/veh/jeep_commander_1.png', N'jeep', N'commander', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (411, CAST(0x00008A6500000000 AS DateTime), NULL, N'Compass v1', N'http://cdn.carvalet.com/img/veh/jeep_compass_1.png', N'jeep', N'compass', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (412, CAST(0x00006F4900000000 AS DateTime), CAST(0x00006F4900000000 AS DateTime), N'Grand Cherokee v1', N'http://cdn.carvalet.com/img/veh/jeep_grand_cherokee_1.png', N'jeep', N'grand_cherokee', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (413, CAST(0x0000901A00000000 AS DateTime), CAST(0x0000946100000000 AS DateTime), N'Patriot v1', N'http://cdn.carvalet.com/img/veh/jeep_patriot_1.png', N'jeep', N'patriot', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (414, CAST(0x000070B600000000 AS DateTime), CAST(0x0000722300000000 AS DateTime), N'Wrangler v1', N'http://cdn.carvalet.com/img/veh/jeep_wrangler_1.png', N'jeep', N'wrangler', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (415, CAST(0x0000699400000000 AS DateTime), CAST(0x00006DDC00000000 AS DateTime), N'Interceptor v1', N'http://cdn.carvalet.com/img/veh/jensen_interceptor_1.png', N'jensen', N'interceptor', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (416, CAST(0x0000901A00000000 AS DateTime), CAST(0x0000946100000000 AS DateTime), N'Carens v1', N'http://cdn.carvalet.com/img/veh/kia_carens_1.png', N'kia', N'carens', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (417, CAST(0x00007D8D00000000 AS DateTime), CAST(0x00007EFB00000000 AS DateTime), N'Ceed v1', N'http://cdn.carvalet.com/img/veh/kia_ceed_1.png', N'kia', N'ceed', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (418, CAST(0x0000918700000000 AS DateTime), NULL, N'Cerato v1', N'http://cdn.carvalet.com/img/veh/kia_cerato_1.png', N'kia', N'cerato', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (419, CAST(0x00006C6E00000000 AS DateTime), CAST(0x00006F4900000000 AS DateTime), N'Clarus v1', N'http://cdn.carvalet.com/img/veh/kia_clarus_1.png', N'kia', N'clarus', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (420, CAST(0x000066B900000000 AS DateTime), CAST(0x0000699400000000 AS DateTime), N'Magentis v1', N'http://cdn.carvalet.com/img/veh/kia_magentis_1.png', N'kia', N'magentis', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (421, CAST(0x00006F4900000000 AS DateTime), CAST(0x000074FE00000000 AS DateTime), N'Mentor v1', N'http://cdn.carvalet.com/img/veh/kia_mentor_1.png', N'kia', N'mentor', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (422, CAST(0x00008BD200000000 AS DateTime), CAST(0x0000918700000000 AS DateTime), N'Optima v1', N'http://cdn.carvalet.com/img/veh/kia_optima_1.png', N'kia', N'optima', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (423, CAST(0x00008BD200000000 AS DateTime), CAST(0x0000918700000000 AS DateTime), N'Picanto v1', N'http://cdn.carvalet.com/img/veh/kia_picanto_1.png', N'kia', N'picanto', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (424, CAST(0x0000918700000000 AS DateTime), CAST(0x0000918700000000 AS DateTime), N'Pride v1', N'http://cdn.carvalet.com/img/veh/kia_pride_1.png', N'kia', N'pride', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (425, CAST(0x000088F700000000 AS DateTime), CAST(0x00008A6500000000 AS DateTime), N'Pro Ceed v1', N'http://cdn.carvalet.com/img/veh/kia_pro_ceed_1.png', N'kia', N'pro_ceed', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (426, CAST(0x00006C6E00000000 AS DateTime), NULL, N'Rio v1', N'http://cdn.carvalet.com/img/veh/kia_rio_1.png', N'kia', N'rio', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (427, CAST(0x0000682700000000 AS DateTime), CAST(0x0000699400000000 AS DateTime), N'Sedona v1', N'http://cdn.carvalet.com/img/veh/kia_sedona_1.png', N'kia', N'sedona', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (428, CAST(0x000098A900000000 AS DateTime), NULL, N'Shuma v1', N'http://cdn.carvalet.com/img/veh/kia_shuma_1.png', N'kia', N'shuma', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (429, CAST(0x000070B600000000 AS DateTime), CAST(0x0000739100000000 AS DateTime), N'Sorento v1', N'http://cdn.carvalet.com/img/veh/kia_sorento_1.png', N'kia', N'sorento', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (430, CAST(0x00007AB300000000 AS DateTime), CAST(0x0000806800000000 AS DateTime), N'Soul v1', N'http://cdn.carvalet.com/img/veh/kia_soul_1.png', N'kia', N'soul', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (431, CAST(0x000098A900000000 AS DateTime), NULL, N'Sportage v1', N'http://cdn.carvalet.com/img/veh/kia_sportage_1.png', N'kia', N'sportage', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (432, CAST(0x0000722300000000 AS DateTime), NULL, N'Venga v1', N'http://cdn.carvalet.com/img/veh/kia_venga_1.png', N'kia', N'venga', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (433, CAST(0x0000794600000000 AS DateTime), CAST(0x00007AB300000000 AS DateTime), N'Agera v1', N'http://cdn.carvalet.com/img/veh/koenigsegg_agera_1.png', N'koenigsegg', N'agera', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (434, CAST(0x000098A900000000 AS DateTime), NULL, N'Cc v1', N'http://cdn.carvalet.com/img/veh/koenigsegg_cc_1.png', N'koenigsegg', N'cc', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (435, CAST(0x0000806800000000 AS DateTime), NULL, N'Ccr v1', N'http://cdn.carvalet.com/img/veh/koenigsegg_ccr_1.png', N'koenigsegg', N'ccr', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (436, CAST(0x0000918700000000 AS DateTime), NULL, N'Ccx v1', N'http://cdn.carvalet.com/img/veh/koenigsegg_ccx_1.png', N'koenigsegg', N'ccx', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (437, CAST(0x00008A6500000000 AS DateTime), NULL, N'Niva v1', N'http://cdn.carvalet.com/img/veh/lada_niva_1.png', N'lada', N'niva', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (438, CAST(0x00008BD200000000 AS DateTime), CAST(0x0000918700000000 AS DateTime), N'Aventador v1', N'http://cdn.carvalet.com/img/veh/lamborghini_aventador_1.png', N'lamborghini', N'aventador', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (439, CAST(0x0000806800000000 AS DateTime), CAST(0x000084B000000000 AS DateTime), N'Countach v1', N'http://cdn.carvalet.com/img/veh/lamborghini_countach_1.png', N'lamborghini', N'countach', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (440, CAST(0x000098A900000000 AS DateTime), NULL, N'Diablo v1', N'http://cdn.carvalet.com/img/veh/lamborghini_diablo_1.png', N'lamborghini', N'diablo', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (441, CAST(0x0000766B00000000 AS DateTime), CAST(0x0000766B00000000 AS DateTime), N'Gallardo v1', N'http://cdn.carvalet.com/img/veh/lamborghini_gallardo_1.png', N'lamborghini', N'gallardo', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (442, CAST(0x0000834200000000 AS DateTime), CAST(0x0000834200000000 AS DateTime), N'Jalpa v1', N'http://cdn.carvalet.com/img/veh/lamborghini_jalpa_1.png', N'lamborghini', N'jalpa', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (443, CAST(0x0000722300000000 AS DateTime), NULL, N'Murcielago v1', N'http://cdn.carvalet.com/img/veh/lamborghini_murcielago_1.png', N'lamborghini', N'murcielago', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (444, CAST(0x0000861D00000000 AS DateTime), CAST(0x00008BD200000000 AS DateTime), N'Reventon v1', N'http://cdn.carvalet.com/img/veh/lamborghini_reventon_1.png', N'lamborghini', N'reventon', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (445, CAST(0x0000699400000000 AS DateTime), NULL, N'2000 v1', N'http://cdn.carvalet.com/img/veh/lancia_2000_1.png', N'lancia', N'2000', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (446, CAST(0x0000834200000000 AS DateTime), CAST(0x0000878A00000000 AS DateTime), N'Beta v1', N'http://cdn.carvalet.com/img/veh/lancia_beta_1.png', N'lancia', N'beta', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (447, CAST(0x0000794600000000 AS DateTime), NULL, N'Delta v1', N'http://cdn.carvalet.com/img/veh/lancia_delta_1.png', N'lancia', N'delta', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (448, CAST(0x0000739100000000 AS DateTime), NULL, N'Y10 v1', N'http://cdn.carvalet.com/img/veh/lancia_y10_1.png', N'lancia', N'y10', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (449, CAST(0x000081D500000000 AS DateTime), CAST(0x0000834200000000 AS DateTime), N'Defender v1', N'http://cdn.carvalet.com/img/veh/land_rover_defender_1.png', N'land_rover', N'defender', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (450, CAST(0x000077D800000000 AS DateTime), NULL, N'Discovery v1', N'http://cdn.carvalet.com/img/veh/land_rover_discovery_1.png', N'land_rover', N'discovery', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (451, CAST(0x0000946100000000 AS DateTime), CAST(0x0000973C00000000 AS DateTime), N'Freelander v1', N'http://cdn.carvalet.com/img/veh/land_rover_freelander_1.png', N'land_rover', N'freelander', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (452, CAST(0x00008A6500000000 AS DateTime), CAST(0x0000901A00000000 AS DateTime), N'Lightweight v1', N'http://cdn.carvalet.com/img/veh/land_rover_lightweight_1.png', N'land_rover', N'lightweight', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (453, CAST(0x000070B600000000 AS DateTime), CAST(0x0000739100000000 AS DateTime), N'Range Rover v1', N'http://cdn.carvalet.com/img/veh/land_rover_range_rover_1.png', N'land_rover', N'range_rover', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (454, CAST(0x000095CF00000000 AS DateTime), NULL, N'Range Rover Evoque v1', N'http://cdn.carvalet.com/img/veh/land_rover_range_rover_evoque_1.png', N'land_rover', N'range_rover_evoque', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (455, CAST(0x0000722300000000 AS DateTime), NULL, N'Range Rover Sport v1', N'http://cdn.carvalet.com/img/veh/land_rover_range_rover_sport_1.png', N'land_rover', N'range_rover_sport', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (456, CAST(0x00006B0100000000 AS DateTime), NULL, N'Series Ii v1', N'http://cdn.carvalet.com/img/veh/land_rover_series_ii_1.png', N'land_rover', N'series_ii', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (457, CAST(0x00007C2000000000 AS DateTime), NULL, N'Series Iii v1', N'http://cdn.carvalet.com/img/veh/land_rover_series_iii_1.png', N'land_rover', N'series_iii', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (458, CAST(0x000077D800000000 AS DateTime), NULL, N'Ct v1', N'http://cdn.carvalet.com/img/veh/lexus_ct_1.png', N'lexus', N'ct', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (459, CAST(0x000063DF00000000 AS DateTime), NULL, N'Gs v1', N'http://cdn.carvalet.com/img/veh/lexus_gs_1.png', N'lexus', N'gs', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (460, CAST(0x00007AB300000000 AS DateTime), NULL, N'Is v1', N'http://cdn.carvalet.com/img/veh/lexus_is_1.png', N'lexus', N'is', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (461, CAST(0x00008D3F00000000 AS DateTime), CAST(0x00008D3F00000000 AS DateTime), N'Ls v1', N'http://cdn.carvalet.com/img/veh/lexus_ls_1.png', N'lexus', N'ls', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (462, CAST(0x0000806800000000 AS DateTime), CAST(0x0000834200000000 AS DateTime), N'Rx v1', N'http://cdn.carvalet.com/img/veh/lexus_rx_1.png', N'lexus', N'rx', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (463, CAST(0x0000722300000000 AS DateTime), NULL, N'Sc v1', N'http://cdn.carvalet.com/img/veh/lexus_sc_1.png', N'lexus', N'sc', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (464, CAST(0x000081D500000000 AS DateTime), NULL, N'Soarer v1', N'http://cdn.carvalet.com/img/veh/lexus_soarer_1.png', N'lexus', N'soarer', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (465, CAST(0x000074FE00000000 AS DateTime), NULL, N'Blackwood v1', N'http://cdn.carvalet.com/img/veh/lincoln_blackwood_1.png', N'lincoln', N'blackwood', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (466, CAST(0x00007D8D00000000 AS DateTime), NULL, N'Navigator v1', N'http://cdn.carvalet.com/img/veh/lincoln_navigator_1.png', N'lincoln', N'navigator', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (467, CAST(0x00007EFB00000000 AS DateTime), CAST(0x0000806800000000 AS DateTime), N'Town Car v1', N'http://cdn.carvalet.com/img/veh/lincoln_town_car_1.png', N'lincoln', N'town_car', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (468, CAST(0x0000861D00000000 AS DateTime), NULL, N'2-Eleven v1', N'http://cdn.carvalet.com/img/veh/lotus_2-eleven_1.png', N'lotus', N'2-eleven', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (469, CAST(0x00006DDC00000000 AS DateTime), CAST(0x00006F4900000000 AS DateTime), N'Carlton v1', N'http://cdn.carvalet.com/img/veh/lotus_carlton_1.png', N'lotus', N'carlton', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (470, CAST(0x000077D800000000 AS DateTime), CAST(0x00007D8D00000000 AS DateTime), N'Eclat v1', N'http://cdn.carvalet.com/img/veh/lotus_eclat_1.png', N'lotus', N'eclat', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (471, CAST(0x000074FE00000000 AS DateTime), NULL, N'Elan v1', N'http://cdn.carvalet.com/img/veh/lotus_elan_1.png', N'lotus', N'elan', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (472, CAST(0x0000722300000000 AS DateTime), CAST(0x000077D800000000 AS DateTime), N'Elise v1', N'http://cdn.carvalet.com/img/veh/lotus_elise_1.png', N'lotus', N'elise', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (473, CAST(0x000077D800000000 AS DateTime), NULL, N'Esprit v1', N'http://cdn.carvalet.com/img/veh/lotus_esprit_1.png', N'lotus', N'esprit', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (474, CAST(0x00007C2000000000 AS DateTime), NULL, N'Europa v1', N'http://cdn.carvalet.com/img/veh/lotus_europa_1.png', N'lotus', N'europa', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (475, CAST(0x0000878A00000000 AS DateTime), CAST(0x00008BD200000000 AS DateTime), N'Evora v1', N'http://cdn.carvalet.com/img/veh/lotus_evora_1.png', N'lotus', N'evora', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (476, CAST(0x00007AB300000000 AS DateTime), CAST(0x00007D8D00000000 AS DateTime), N'Excel v1', N'http://cdn.carvalet.com/img/veh/lotus_excel_1.png', N'lotus', N'excel', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (477, CAST(0x00006C6E00000000 AS DateTime), NULL, N'Exige v1', N'http://cdn.carvalet.com/img/veh/lotus_exige_1.png', N'lotus', N'exige', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (478, CAST(0x00007D8D00000000 AS DateTime), NULL, N'Seven v1', N'http://cdn.carvalet.com/img/veh/lotus_seven_1.png', N'lotus', N'seven', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (479, CAST(0x0000766B00000000 AS DateTime), CAST(0x0000794600000000 AS DateTime), N'Tx4 v1', N'http://cdn.carvalet.com/img/veh/lti_tx4_1.png', N'lti', N'tx4', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (480, CAST(0x0000834200000000 AS DateTime), CAST(0x0000878A00000000 AS DateTime), N'Txi v1', N'http://cdn.carvalet.com/img/veh/lti_txi_1.png', N'lti', N'txi', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (481, CAST(0x0000682700000000 AS DateTime), NULL, N'Txii v1', N'http://cdn.carvalet.com/img/veh/lti_txii_1.png', N'lti', N'txii', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (482, CAST(0x00007D8D00000000 AS DateTime), NULL, N'3200 v1', N'http://cdn.carvalet.com/img/veh/maserati_3200_1.png', N'maserati', N'3200', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (483, CAST(0x00007D8D00000000 AS DateTime), CAST(0x000081D500000000 AS DateTime), N'4200 v1', N'http://cdn.carvalet.com/img/veh/maserati_4200_1.png', N'maserati', N'4200', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (484, CAST(0x000077D800000000 AS DateTime), CAST(0x00007D8D00000000 AS DateTime), N'430 v1', N'http://cdn.carvalet.com/img/veh/maserati_430_1.png', N'maserati', N'430', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (485, CAST(0x0000806800000000 AS DateTime), CAST(0x000084B000000000 AS DateTime), N'Coupe v1', N'http://cdn.carvalet.com/img/veh/maserati_coupe_1.png', N'maserati', N'coupe', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (486, CAST(0x00008A6500000000 AS DateTime), CAST(0x00008EAC00000000 AS DateTime), N'Ghibli v1', N'http://cdn.carvalet.com/img/veh/maserati_ghibli_1.png', N'maserati', N'ghibli', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (487, CAST(0x000092F400000000 AS DateTime), NULL, N'Grancabrio v1', N'http://cdn.carvalet.com/img/veh/maserati_grancabrio_1.png', N'maserati', N'grancabrio', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (488, CAST(0x00006DDC00000000 AS DateTime), NULL, N'Gransport v1', N'http://cdn.carvalet.com/img/veh/maserati_gransport_1.png', N'maserati', N'gransport', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (489, CAST(0x000098A900000000 AS DateTime), CAST(0x00009CF100000000 AS DateTime), N'Granturismo v1', N'http://cdn.carvalet.com/img/veh/maserati_granturismo_1.png', N'maserati', N'granturismo', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (490, CAST(0x000084B000000000 AS DateTime), CAST(0x000084B000000000 AS DateTime), N'Indy v1', N'http://cdn.carvalet.com/img/veh/maserati_indy_1.png', N'maserati', N'indy', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (491, CAST(0x0000901A00000000 AS DateTime), NULL, N'Quattroporte v1', N'http://cdn.carvalet.com/img/veh/maserati_quattroporte_1.png', N'maserati', N'quattroporte', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (492, CAST(0x000077D800000000 AS DateTime), NULL, N'Spyder v1', N'http://cdn.carvalet.com/img/veh/maserati_spyder_1.png', N'maserati', N'spyder', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (493, CAST(0x0000918700000000 AS DateTime), CAST(0x0000946100000000 AS DateTime), N'57 v1', N'http://cdn.carvalet.com/img/veh/maybach_57_1.png', N'maybach', N'57', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (494, CAST(0x000063DF00000000 AS DateTime), NULL, N'62 v1', N'http://cdn.carvalet.com/img/veh/maybach_62_1.png', N'maybach', N'62', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (495, CAST(0x0000654C00000000 AS DateTime), NULL, N'121 v1', N'http://cdn.carvalet.com/img/veh/mazda_121_1.png', N'mazda', N'121', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (496, CAST(0x00006F4900000000 AS DateTime), CAST(0x000070B600000000 AS DateTime), N'2 v1', N'http://cdn.carvalet.com/img/veh/mazda_2_1.png', N'mazda', N'2', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (497, CAST(0x0000918700000000 AS DateTime), NULL, N'323 v1', N'http://cdn.carvalet.com/img/veh/mazda_323_1.png', N'mazda', N'323', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (498, CAST(0x000088F700000000 AS DateTime), NULL, N'626 v1', N'http://cdn.carvalet.com/img/veh/mazda_626_1.png', N'mazda', N'626', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (499, CAST(0x0000973C00000000 AS DateTime), CAST(0x00009CF100000000 AS DateTime), N'Bongo v1', N'http://cdn.carvalet.com/img/veh/mazda_bongo_1.png', N'mazda', N'bongo', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (500, CAST(0x00008BD200000000 AS DateTime), NULL, N'B-Series v1', N'http://cdn.carvalet.com/img/veh/mazda_b-series_1.png', N'mazda', N'b-series', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (501, CAST(0x000088F700000000 AS DateTime), CAST(0x00008A6500000000 AS DateTime), N'Bt-50 v1', N'http://cdn.carvalet.com/img/veh/mazda_bt-50_1.png', N'mazda', N'bt-50', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (502, CAST(0x0000794600000000 AS DateTime), CAST(0x00007D8D00000000 AS DateTime), N'Cosmo v1', N'http://cdn.carvalet.com/img/veh/mazda_cosmo_1.png', N'mazda', N'cosmo', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (503, CAST(0x0000699400000000 AS DateTime), CAST(0x00006F4900000000 AS DateTime), N'Cx-7 v1', N'http://cdn.carvalet.com/img/veh/mazda_cx-7_1.png', N'mazda', N'cx-7', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (504, CAST(0x00006F4900000000 AS DateTime), NULL, N'Demio v1', N'http://cdn.carvalet.com/img/veh/mazda_demio_1.png', N'mazda', N'demio', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (505, CAST(0x000084B000000000 AS DateTime), CAST(0x000084B000000000 AS DateTime), N'Eunos v1', N'http://cdn.carvalet.com/img/veh/mazda_eunos_1.png', N'mazda', N'eunos', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (506, CAST(0x000088F700000000 AS DateTime), NULL, N'Mazda2 v1', N'http://cdn.carvalet.com/img/veh/mazda_mazda2_1.png', N'mazda', N'mazda2', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (507, CAST(0x00006B0100000000 AS DateTime), NULL, N'Mazda3 v1', N'http://cdn.carvalet.com/img/veh/mazda_mazda3_1.png', N'mazda', N'mazda3', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (508, CAST(0x0000861D00000000 AS DateTime), NULL, N'Mazda5 v1', N'http://cdn.carvalet.com/img/veh/mazda_mazda5_1.png', N'mazda', N'mazda5', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (509, CAST(0x0000739100000000 AS DateTime), CAST(0x000077D800000000 AS DateTime), N'Mazda6 v1', N'http://cdn.carvalet.com/img/veh/mazda_mazda6_1.png', N'mazda', N'mazda6', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (510, CAST(0x00006F4900000000 AS DateTime), CAST(0x00006F4900000000 AS DateTime), N'Mpv v1', N'http://cdn.carvalet.com/img/veh/mazda_mpv_1.png', N'mazda', N'mpv', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (511, CAST(0x0000834200000000 AS DateTime), CAST(0x0000878A00000000 AS DateTime), N'Mx-3 v1', N'http://cdn.carvalet.com/img/veh/mazda_mx-3_1.png', N'mazda', N'mx-3', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (512, CAST(0x0000861D00000000 AS DateTime), NULL, N'Mx-5 v1', N'http://cdn.carvalet.com/img/veh/mazda_mx-5_1.png', N'mazda', N'mx-5', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (513, CAST(0x0000682700000000 AS DateTime), CAST(0x00006C6E00000000 AS DateTime), N'Mx-6 v1', N'http://cdn.carvalet.com/img/veh/mazda_mx-6_1.png', N'mazda', N'mx-6', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (514, CAST(0x0000878A00000000 AS DateTime), CAST(0x00008A6500000000 AS DateTime), N'Premacy v1', N'http://cdn.carvalet.com/img/veh/mazda_premacy_1.png', N'mazda', N'premacy', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (515, CAST(0x000098A900000000 AS DateTime), NULL, N'Rx7 v1', N'http://cdn.carvalet.com/img/veh/mazda_rx7_1.png', N'mazda', N'rx7', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (516, CAST(0x000077D800000000 AS DateTime), NULL, N'Rx8 v1', N'http://cdn.carvalet.com/img/veh/mazda_rx8_1.png', N'mazda', N'rx8', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (517, CAST(0x0000794600000000 AS DateTime), NULL, N'Tribute v1', N'http://cdn.carvalet.com/img/veh/mazda_tribute_1.png', N'mazda', N'tribute', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (518, CAST(0x000098A900000000 AS DateTime), NULL, N'Xedos v1', N'http://cdn.carvalet.com/img/veh/mazda_xedos_1.png', N'mazda', N'xedos', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (519, CAST(0x0000834200000000 AS DateTime), CAST(0x000084B000000000 AS DateTime), N'F1 v1', N'http://cdn.carvalet.com/img/veh/mclaren_f1_1.png', N'mclaren', N'f1', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (520, CAST(0x000063DF00000000 AS DateTime), CAST(0x0000699400000000 AS DateTime), N'Mp4 v1', N'http://cdn.carvalet.com/img/veh/mclaren_mp4_1.png', N'mclaren', N'mp4', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (521, CAST(0x0000861D00000000 AS DateTime), CAST(0x00008A6500000000 AS DateTime), N'180 v1', N'http://cdn.carvalet.com/img/veh/mercedes-benz_180_1.png', N'mercedes-benz', N'180', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (522, CAST(0x0000946100000000 AS DateTime), CAST(0x000095CF00000000 AS DateTime), N'190 v1', N'http://cdn.carvalet.com/img/veh/mercedes-benz_190_1.png', N'mercedes-benz', N'190', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (523, CAST(0x0000699400000000 AS DateTime), NULL, N'200 v1', N'http://cdn.carvalet.com/img/veh/mercedes-benz_200_1.png', N'mercedes-benz', N'200', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (524, CAST(0x00008EAC00000000 AS DateTime), CAST(0x0000946100000000 AS DateTime), N'220 v1', N'http://cdn.carvalet.com/img/veh/mercedes-benz_220_1.png', N'mercedes-benz', N'220', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (525, CAST(0x0000918700000000 AS DateTime), CAST(0x000092F400000000 AS DateTime), N'230 v1', N'http://cdn.carvalet.com/img/veh/mercedes-benz_230_1.png', N'mercedes-benz', N'230', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (526, CAST(0x000077D800000000 AS DateTime), NULL, N'240 v1', N'http://cdn.carvalet.com/img/veh/mercedes-benz_240_1.png', N'mercedes-benz', N'240', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (527, CAST(0x0000722300000000 AS DateTime), CAST(0x000074FE00000000 AS DateTime), N'250 v1', N'http://cdn.carvalet.com/img/veh/mercedes-benz_250_1.png', N'mercedes-benz', N'250', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (528, CAST(0x000084B000000000 AS DateTime), NULL, N'280 v1', N'http://cdn.carvalet.com/img/veh/mercedes-benz_280_1.png', N'mercedes-benz', N'280', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (529, CAST(0x0000946100000000 AS DateTime), CAST(0x000095CF00000000 AS DateTime), N'300 v1', N'http://cdn.carvalet.com/img/veh/mercedes-benz_300_1.png', N'mercedes-benz', N'300', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (530, CAST(0x000092F400000000 AS DateTime), NULL, N'320 v1', N'http://cdn.carvalet.com/img/veh/mercedes-benz_320_1.png', N'mercedes-benz', N'320', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (531, CAST(0x0000878A00000000 AS DateTime), CAST(0x000088F700000000 AS DateTime), N'350 v1', N'http://cdn.carvalet.com/img/veh/mercedes-benz_350_1.png', N'mercedes-benz', N'350', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (532, CAST(0x0000699400000000 AS DateTime), CAST(0x00006B0100000000 AS DateTime), N'380 v1', N'http://cdn.carvalet.com/img/veh/mercedes-benz_380_1.png', N'mercedes-benz', N'380', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (533, CAST(0x000095CF00000000 AS DateTime), NULL, N'420 v1', N'http://cdn.carvalet.com/img/veh/mercedes-benz_420_1.png', N'mercedes-benz', N'420', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (534, CAST(0x00006DDC00000000 AS DateTime), NULL, N'450 v1', N'http://cdn.carvalet.com/img/veh/mercedes-benz_450_1.png', N'mercedes-benz', N'450', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (535, CAST(0x000074FE00000000 AS DateTime), NULL, N'500 v1', N'http://cdn.carvalet.com/img/veh/mercedes-benz_500_1.png', N'mercedes-benz', N'500', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (536, CAST(0x00007C2000000000 AS DateTime), CAST(0x00007D8D00000000 AS DateTime), N'560 v1', N'http://cdn.carvalet.com/img/veh/mercedes-benz_560_1.png', N'mercedes-benz', N'560', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (537, CAST(0x0000806800000000 AS DateTime), CAST(0x000081D500000000 AS DateTime), N'600 v1', N'http://cdn.carvalet.com/img/veh/mercedes-benz_600_1.png', N'mercedes-benz', N'600', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (538, CAST(0x00008D3F00000000 AS DateTime), NULL, N'A Class v1', N'http://cdn.carvalet.com/img/veh/mercedes-benz_a_class_1.png', N'mercedes-benz', N'a_class', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (539, CAST(0x0000682700000000 AS DateTime), NULL, N'B Class v1', N'http://cdn.carvalet.com/img/veh/mercedes-benz_b_class_1.png', N'mercedes-benz', N'b_class', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (540, CAST(0x000066B900000000 AS DateTime), NULL, N'C Class v1', N'http://cdn.carvalet.com/img/veh/mercedes-benz_c_class_1.png', N'mercedes-benz', N'c_class', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (541, CAST(0x0000878A00000000 AS DateTime), NULL, N'Ce Class v1', N'http://cdn.carvalet.com/img/veh/mercedes-benz_ce_class_1.png', N'mercedes-benz', N'ce_class', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (542, CAST(0x00007AB300000000 AS DateTime), NULL, N'Cl v1', N'http://cdn.carvalet.com/img/veh/mercedes-benz_cl_1.png', N'mercedes-benz', N'cl', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (543, CAST(0x0000861D00000000 AS DateTime), CAST(0x0000861D00000000 AS DateTime), N'Clc Class v1', N'http://cdn.carvalet.com/img/veh/mercedes-benz_clc_class_1.png', N'mercedes-benz', N'clc_class', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (544, CAST(0x0000794600000000 AS DateTime), CAST(0x0000794600000000 AS DateTime), N'Clk v1', N'http://cdn.carvalet.com/img/veh/mercedes-benz_clk_1.png', N'mercedes-benz', N'clk', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (545, CAST(0x0000834200000000 AS DateTime), NULL, N'Cls v1', N'http://cdn.carvalet.com/img/veh/mercedes-benz_cls_1.png', N'mercedes-benz', N'cls', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (546, CAST(0x000066B900000000 AS DateTime), NULL, N'E Class v1', N'http://cdn.carvalet.com/img/veh/mercedes-benz_e_class_1.png', N'mercedes-benz', N'e_class', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (547, CAST(0x0000901A00000000 AS DateTime), CAST(0x000095CF00000000 AS DateTime), N'G Class v1', N'http://cdn.carvalet.com/img/veh/mercedes-benz_g_class_1.png', N'mercedes-benz', N'g_class', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (548, CAST(0x000077D800000000 AS DateTime), CAST(0x00007C2000000000 AS DateTime), N'Gl Class v1', N'http://cdn.carvalet.com/img/veh/mercedes-benz_gl_class_1.png', N'mercedes-benz', N'gl_class', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (549, CAST(0x00006DDC00000000 AS DateTime), CAST(0x0000739100000000 AS DateTime), N'M Class v1', N'http://cdn.carvalet.com/img/veh/mercedes-benz_m_class_1.png', N'mercedes-benz', N'm_class', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (550, CAST(0x00008A6500000000 AS DateTime), CAST(0x00008EAC00000000 AS DateTime), N'R Class v1', N'http://cdn.carvalet.com/img/veh/mercedes-benz_r_class_1.png', N'mercedes-benz', N'r_class', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (551, CAST(0x0000699400000000 AS DateTime), NULL, N'S Class v1', N'http://cdn.carvalet.com/img/veh/mercedes-benz_s_class_1.png', N'mercedes-benz', N's_class', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (552, CAST(0x000081D500000000 AS DateTime), NULL, N'Se Class v1', N'http://cdn.carvalet.com/img/veh/mercedes-benz_se_class_1.png', N'mercedes-benz', N'se_class', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (553, CAST(0x0000682700000000 AS DateTime), NULL, N'Sec Series v1', N'http://cdn.carvalet.com/img/veh/mercedes-benz_sec_series_1.png', N'mercedes-benz', N'sec_series', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (554, CAST(0x00008BD200000000 AS DateTime), NULL, N'Sel Series v1', N'http://cdn.carvalet.com/img/veh/mercedes-benz_sel_series_1.png', N'mercedes-benz', N'sel_series', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (555, CAST(0x00007AB300000000 AS DateTime), NULL, N'Sl Class v1', N'http://cdn.carvalet.com/img/veh/mercedes-benz_sl_class_1.png', N'mercedes-benz', N'sl_class', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (556, CAST(0x0000901A00000000 AS DateTime), CAST(0x0000918700000000 AS DateTime), N'Slk v1', N'http://cdn.carvalet.com/img/veh/mercedes-benz_slk_1.png', N'mercedes-benz', N'slk', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (557, CAST(0x00007D8D00000000 AS DateTime), NULL, N'Slr Mclaren v1', N'http://cdn.carvalet.com/img/veh/mercedes-benz_slr_mclaren_1.png', N'mercedes-benz', N'slr_mclaren', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (558, CAST(0x0000946100000000 AS DateTime), NULL, N'Sls v1', N'http://cdn.carvalet.com/img/veh/mercedes-benz_sls_1.png', N'mercedes-benz', N'sls', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (559, CAST(0x0000794600000000 AS DateTime), CAST(0x0000794600000000 AS DateTime), N'V Class v1', N'http://cdn.carvalet.com/img/veh/mercedes-benz_v_class_1.png', N'mercedes-benz', N'v_class', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (560, CAST(0x00007C2000000000 AS DateTime), NULL, N'Vaneo v1', N'http://cdn.carvalet.com/img/veh/mercedes-benz_vaneo_1.png', N'mercedes-benz', N'vaneo', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (561, CAST(0x00007EFB00000000 AS DateTime), NULL, N'Viano v1', N'http://cdn.carvalet.com/img/veh/mercedes-benz_viano_1.png', N'mercedes-benz', N'viano', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (562, CAST(0x000084B000000000 AS DateTime), CAST(0x0000878A00000000 AS DateTime), N'Vito v1', N'http://cdn.carvalet.com/img/veh/mercedes-benz_vito_1.png', N'mercedes-benz', N'vito', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (563, CAST(0x00007AB300000000 AS DateTime), CAST(0x00007AB300000000 AS DateTime), N'Mg6 v1', N'http://cdn.carvalet.com/img/veh/mg_mg6_1.png', N'mg', N'mg6', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (564, CAST(0x00006C6E00000000 AS DateTime), CAST(0x0000722300000000 AS DateTime), N'Mga v1', N'http://cdn.carvalet.com/img/veh/mg_mga_1.png', N'mg', N'mga', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (565, CAST(0x000063DF00000000 AS DateTime), NULL, N'Mgb v1', N'http://cdn.carvalet.com/img/veh/mg_mgb_1.png', N'mg', N'mgb', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (566, CAST(0x00006B0100000000 AS DateTime), NULL, N'Mgc v1', N'http://cdn.carvalet.com/img/veh/mg_mgc_1.png', N'mg', N'mgc', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (567, CAST(0x0000878A00000000 AS DateTime), CAST(0x00008A6500000000 AS DateTime), N'Mgf v1', N'http://cdn.carvalet.com/img/veh/mg_mgf_1.png', N'mg', N'mgf', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (568, CAST(0x0000834200000000 AS DateTime), NULL, N'Midget v1', N'http://cdn.carvalet.com/img/veh/mg_midget_1.png', N'mg', N'midget', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (569, CAST(0x0000722300000000 AS DateTime), CAST(0x0000766B00000000 AS DateTime), N'Roadster v1', N'http://cdn.carvalet.com/img/veh/mg_roadster_1.png', N'mg', N'roadster', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (570, CAST(0x000070B600000000 AS DateTime), NULL, N'Rv8 v1', N'http://cdn.carvalet.com/img/veh/mg_rv8_1.png', N'mg', N'rv8', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (571, CAST(0x0000878A00000000 AS DateTime), NULL, N'Sv v1', N'http://cdn.carvalet.com/img/veh/mg_sv_1.png', N'mg', N'sv', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (572, CAST(0x0000722300000000 AS DateTime), CAST(0x000074FE00000000 AS DateTime), N'Td v1', N'http://cdn.carvalet.com/img/veh/mg_td_1.png', N'mg', N'td', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (573, CAST(0x00007C2000000000 AS DateTime), CAST(0x00007C2000000000 AS DateTime), N'Tf v1', N'http://cdn.carvalet.com/img/veh/mg_tf_1.png', N'mg', N'tf', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (574, CAST(0x000098A900000000 AS DateTime), NULL, N'Zr v1', N'http://cdn.carvalet.com/img/veh/mg_zr_1.png', N'mg', N'zr', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (575, CAST(0x0000794600000000 AS DateTime), NULL, N'Zs v1', N'http://cdn.carvalet.com/img/veh/mg_zs_1.png', N'mg', N'zs', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (576, CAST(0x000077D800000000 AS DateTime), NULL, N'Zt v1', N'http://cdn.carvalet.com/img/veh/mg_zt_1.png', N'mg', N'zt', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (577, CAST(0x0000739100000000 AS DateTime), CAST(0x000074FE00000000 AS DateTime), N'Zt-T v1', N'http://cdn.carvalet.com/img/veh/mg_zt-t_1.png', N'mg', N'zt-t', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (578, CAST(0x0000654C00000000 AS DateTime), NULL, N'Mg6 v1', N'http://cdn.carvalet.com/img/veh/mg_motor_uk_mg6_1.png', N'mg_motor_uk', N'mg6', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (579, CAST(0x00008A6500000000 AS DateTime), NULL, N'Mgtf v1', N'http://cdn.carvalet.com/img/veh/mg_motor_uk_mgtf_1.png', N'mg_motor_uk', N'mgtf', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (580, CAST(0x000092F400000000 AS DateTime), NULL, N'M.Go v1', N'http://cdn.carvalet.com/img/veh/microcar_m.go_1.png', N'microcar', N'm.go', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (581, CAST(0x0000682700000000 AS DateTime), NULL, N'Mc1 v1', N'http://cdn.carvalet.com/img/veh/microcar_mc1_1.png', N'microcar', N'mc1', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (582, CAST(0x00007AB300000000 AS DateTime), CAST(0x00007D8D00000000 AS DateTime), N'Mc2 v1', N'http://cdn.carvalet.com/img/veh/microcar_mc2_1.png', N'microcar', N'mc2', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (583, CAST(0x000088F700000000 AS DateTime), NULL, N'Virgo v1', N'http://cdn.carvalet.com/img/veh/microcar_virgo_1.png', N'microcar', N'virgo', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (584, CAST(0x000092F400000000 AS DateTime), CAST(0x0000946100000000 AS DateTime), N'Cooper v1', N'http://cdn.carvalet.com/img/veh/mini_cooper_1.png', N'mini', N'cooper', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (585, CAST(0x0000806800000000 AS DateTime), NULL, N'Cooper S v1', N'http://cdn.carvalet.com/img/veh/mini_cooper_s_1.png', N'mini', N'cooper_s', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (586, CAST(0x00007EFB00000000 AS DateTime), NULL, N'First v1', N'http://cdn.carvalet.com/img/veh/mini_first_1.png', N'mini', N'first', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (587, CAST(0x00006DDC00000000 AS DateTime), NULL, N'Hatchback v1', N'http://cdn.carvalet.com/img/veh/mini_hatchback_1.png', N'mini', N'hatchback', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (588, CAST(0x000070B600000000 AS DateTime), CAST(0x0000766B00000000 AS DateTime), N'One v1', N'http://cdn.carvalet.com/img/veh/mini_one_1.png', N'mini', N'one', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (589, CAST(0x000084B000000000 AS DateTime), CAST(0x0000878A00000000 AS DateTime), N'3000Gt v1', N'http://cdn.carvalet.com/img/veh/mitsubishi_3000gt_1.png', N'mitsubishi', N'3000gt', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (590, CAST(0x000095CF00000000 AS DateTime), NULL, N'Asx v1', N'http://cdn.carvalet.com/img/veh/mitsubishi_asx_1.png', N'mitsubishi', N'asx', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (591, CAST(0x0000973C00000000 AS DateTime), CAST(0x000098A900000000 AS DateTime), N'Carisma v1', N'http://cdn.carvalet.com/img/veh/mitsubishi_carisma_1.png', N'mitsubishi', N'carisma', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (592, CAST(0x000095CF00000000 AS DateTime), NULL, N'Challenger v1', N'http://cdn.carvalet.com/img/veh/mitsubishi_challenger_1.png', N'mitsubishi', N'challenger', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (593, CAST(0x0000878A00000000 AS DateTime), NULL, N'Chariot v1', N'http://cdn.carvalet.com/img/veh/mitsubishi_chariot_1.png', N'mitsubishi', N'chariot', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (594, CAST(0x0000973C00000000 AS DateTime), CAST(0x000098A900000000 AS DateTime), N'Colt v1', N'http://cdn.carvalet.com/img/veh/mitsubishi_colt_1.png', N'mitsubishi', N'colt', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (595, CAST(0x00006DDC00000000 AS DateTime), NULL, N'Delica v1', N'http://cdn.carvalet.com/img/veh/mitsubishi_delica_1.png', N'mitsubishi', N'delica', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (596, CAST(0x0000654C00000000 AS DateTime), NULL, N'Fto v1', N'http://cdn.carvalet.com/img/veh/mitsubishi_fto_1.png', N'mitsubishi', N'fto', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (597, CAST(0x00008A6500000000 AS DateTime), NULL, N'Galant v1', N'http://cdn.carvalet.com/img/veh/mitsubishi_galant_1.png', N'mitsubishi', N'galant', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (598, CAST(0x00006B0100000000 AS DateTime), NULL, N'Grandis v1', N'http://cdn.carvalet.com/img/veh/mitsubishi_grandis_1.png', N'mitsubishi', N'grandis', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (599, CAST(0x000098A900000000 AS DateTime), NULL, N'Gto v1', N'http://cdn.carvalet.com/img/veh/mitsubishi_gto_1.png', N'mitsubishi', N'gto', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (600, CAST(0x0000918700000000 AS DateTime), NULL, N'I-Car v1', N'http://cdn.carvalet.com/img/veh/mitsubishi_i-car_1.png', N'mitsubishi', N'i-car', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (601, CAST(0x00008D3F00000000 AS DateTime), CAST(0x00008D3F00000000 AS DateTime), N'I-Miev v1', N'http://cdn.carvalet.com/img/veh/mitsubishi_i-miev_1.png', N'mitsubishi', N'i-miev', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (602, CAST(0x000074FE00000000 AS DateTime), CAST(0x00007AB300000000 AS DateTime), N'L200 v1', N'http://cdn.carvalet.com/img/veh/mitsubishi_l200_1.png', N'mitsubishi', N'l200', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (603, CAST(0x0000766B00000000 AS DateTime), NULL, N'Lancer v1', N'http://cdn.carvalet.com/img/veh/mitsubishi_lancer_1.png', N'mitsubishi', N'lancer', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (604, CAST(0x0000901A00000000 AS DateTime), CAST(0x0000901A00000000 AS DateTime), N'Legnum v1', N'http://cdn.carvalet.com/img/veh/mitsubishi_legnum_1.png', N'mitsubishi', N'legnum', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (605, CAST(0x0000918700000000 AS DateTime), CAST(0x0000918700000000 AS DateTime), N'Outlander v1', N'http://cdn.carvalet.com/img/veh/mitsubishi_outlander_1.png', N'mitsubishi', N'outlander', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (606, CAST(0x0000766B00000000 AS DateTime), CAST(0x000077D800000000 AS DateTime), N'Pajero v1', N'http://cdn.carvalet.com/img/veh/mitsubishi_pajero_1.png', N'mitsubishi', N'pajero', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (607, CAST(0x00008A6500000000 AS DateTime), CAST(0x00008D3F00000000 AS DateTime), N'Pajero Junior v1', N'http://cdn.carvalet.com/img/veh/mitsubishi_pajero_junior_1.png', N'mitsubishi', N'pajero_junior', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (608, CAST(0x000098A900000000 AS DateTime), CAST(0x00009A1600000000 AS DateTime), N'Shogun v1', N'http://cdn.carvalet.com/img/veh/mitsubishi_shogun_1.png', N'mitsubishi', N'shogun', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (609, CAST(0x0000739100000000 AS DateTime), CAST(0x0000766B00000000 AS DateTime), N'Shogun Pinin v1', N'http://cdn.carvalet.com/img/veh/mitsubishi_shogun_pinin_1.png', N'mitsubishi', N'shogun_pinin', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (610, CAST(0x000066B900000000 AS DateTime), NULL, N'Shogun Sport v1', N'http://cdn.carvalet.com/img/veh/mitsubishi_shogun_sport_1.png', N'mitsubishi', N'shogun_sport', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (611, CAST(0x00007C2000000000 AS DateTime), NULL, N'Space Runner v1', N'http://cdn.carvalet.com/img/veh/mitsubishi_space_runner_1.png', N'mitsubishi', N'space_runner', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (612, CAST(0x00007AB300000000 AS DateTime), NULL, N'Space Star v1', N'http://cdn.carvalet.com/img/veh/mitsubishi_space_star_1.png', N'mitsubishi', N'space_star', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (613, CAST(0x00008A6500000000 AS DateTime), CAST(0x00008D3F00000000 AS DateTime), N'Space Wagon v1', N'http://cdn.carvalet.com/img/veh/mitsubishi_space_wagon_1.png', N'mitsubishi', N'space_wagon', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (614, CAST(0x0000806800000000 AS DateTime), NULL, N'Viewt v1', N'http://cdn.carvalet.com/img/veh/mitsuoka_viewt_1.png', N'mitsuoka', N'viewt', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (615, CAST(0x000070B600000000 AS DateTime), CAST(0x0000739100000000 AS DateTime), N'4/4 v1', N'http://cdn.carvalet.com/img/veh/morgan_4]]4_1.png', N'morgan', N'4]]4', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (616, CAST(0x0000834200000000 AS DateTime), NULL, N'Aero v1', N'http://cdn.carvalet.com/img/veh/morgan_aero_1.png', N'morgan', N'aero', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (617, CAST(0x0000806800000000 AS DateTime), NULL, N'Aero Supersports v1', N'http://cdn.carvalet.com/img/veh/morgan_aero_supersports_1.png', N'morgan', N'aero_supersports', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (618, CAST(0x0000901A00000000 AS DateTime), NULL, N'Plus 4 v1', N'http://cdn.carvalet.com/img/veh/morgan_plus_4_1.png', N'morgan', N'plus_4', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (619, CAST(0x000095CF00000000 AS DateTime), NULL, N'Plus 8 v1', N'http://cdn.carvalet.com/img/veh/morgan_plus_8_1.png', N'morgan', N'plus_8', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (620, CAST(0x0000699400000000 AS DateTime), NULL, N'Roadster v1', N'http://cdn.carvalet.com/img/veh/morgan_roadster_1.png', N'morgan', N'roadster', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (621, CAST(0x0000722300000000 AS DateTime), CAST(0x000074FE00000000 AS DateTime), N'Mini v1', N'http://cdn.carvalet.com/img/veh/morris_mini_1.png', N'morris', N'mini', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (622, CAST(0x0000739100000000 AS DateTime), CAST(0x000077D800000000 AS DateTime), N'Minor v1', N'http://cdn.carvalet.com/img/veh/morris_minor_1.png', N'morris', N'minor', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (623, CAST(0x00007AB300000000 AS DateTime), NULL, N'Oxford v1', N'http://cdn.carvalet.com/img/veh/morris_oxford_1.png', N'morris', N'oxford', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (624, CAST(0x0000878A00000000 AS DateTime), CAST(0x00008D3F00000000 AS DateTime), N'100 Nx v1', N'http://cdn.carvalet.com/img/veh/nissan_100_nx_1.png', N'nissan', N'100_nx', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (625, CAST(0x000098A900000000 AS DateTime), NULL, N'200 Sx v1', N'http://cdn.carvalet.com/img/veh/nissan_200_sx_1.png', N'nissan', N'200_sx', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (626, CAST(0x0000878A00000000 AS DateTime), NULL, N'300 Zx v1', N'http://cdn.carvalet.com/img/veh/nissan_300_zx_1.png', N'nissan', N'300_zx', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (627, CAST(0x00007EFB00000000 AS DateTime), CAST(0x0000834200000000 AS DateTime), N'350 Z v1', N'http://cdn.carvalet.com/img/veh/nissan_350_z_1.png', N'nissan', N'350_z', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (628, CAST(0x0000878A00000000 AS DateTime), NULL, N'370 Z v1', N'http://cdn.carvalet.com/img/veh/nissan_370_z_1.png', N'nissan', N'370_z', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (629, CAST(0x00006B0100000000 AS DateTime), CAST(0x000070B600000000 AS DateTime), N'Almera v1', N'http://cdn.carvalet.com/img/veh/nissan_almera_1.png', N'nissan', N'almera', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (630, CAST(0x0000722300000000 AS DateTime), NULL, N'Almera Tino v1', N'http://cdn.carvalet.com/img/veh/nissan_almera_tino_1.png', N'nissan', N'almera_tino', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (631, CAST(0x00007AB300000000 AS DateTime), CAST(0x0000806800000000 AS DateTime), N'Bluebird v1', N'http://cdn.carvalet.com/img/veh/nissan_bluebird_1.png', N'nissan', N'bluebird', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (632, CAST(0x00007C2000000000 AS DateTime), NULL, N'Cherry v1', N'http://cdn.carvalet.com/img/veh/nissan_cherry_1.png', N'nissan', N'cherry', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (633, CAST(0x000084B000000000 AS DateTime), CAST(0x0000861D00000000 AS DateTime), N'Cube v1', N'http://cdn.carvalet.com/img/veh/nissan_cube_1.png', N'nissan', N'cube', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (634, CAST(0x00006F4900000000 AS DateTime), NULL, N'Elgrand v1', N'http://cdn.carvalet.com/img/veh/nissan_elgrand_1.png', N'nissan', N'elgrand', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (635, CAST(0x00006C6E00000000 AS DateTime), NULL, N'Figaro v1', N'http://cdn.carvalet.com/img/veh/nissan_figaro_1.png', N'nissan', N'figaro', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (636, CAST(0x00007AB300000000 AS DateTime), NULL, N'Gt-R v1', N'http://cdn.carvalet.com/img/veh/nissan_gt-r_1.png', N'nissan', N'gt-r', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (637, CAST(0x000092F400000000 AS DateTime), NULL, N'Juke v1', N'http://cdn.carvalet.com/img/veh/nissan_juke_1.png', N'nissan', N'juke', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (638, CAST(0x000095CF00000000 AS DateTime), NULL, N'Largo v1', N'http://cdn.carvalet.com/img/veh/nissan_largo_1.png', N'nissan', N'largo', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (639, CAST(0x0000806800000000 AS DateTime), NULL, N'Leaf v1', N'http://cdn.carvalet.com/img/veh/nissan_leaf_1.png', N'nissan', N'leaf', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (640, CAST(0x000084B000000000 AS DateTime), NULL, N'Maxima v1', N'http://cdn.carvalet.com/img/veh/nissan_maxima_1.png', N'nissan', N'maxima', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (641, CAST(0x0000918700000000 AS DateTime), CAST(0x000092F400000000 AS DateTime), N'Micra v1', N'http://cdn.carvalet.com/img/veh/nissan_micra_1.png', N'nissan', N'micra', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (642, CAST(0x000063DF00000000 AS DateTime), CAST(0x0000699400000000 AS DateTime), N'Mistral v1', N'http://cdn.carvalet.com/img/veh/nissan_mistral_1.png', N'nissan', N'mistral', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (643, CAST(0x0000739100000000 AS DateTime), CAST(0x000074FE00000000 AS DateTime), N'Murano v1', N'http://cdn.carvalet.com/img/veh/nissan_murano_1.png', N'nissan', N'murano', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (644, CAST(0x0000794600000000 AS DateTime), CAST(0x00007AB300000000 AS DateTime), N'Navara v1', N'http://cdn.carvalet.com/img/veh/nissan_navara_1.png', N'nissan', N'navara', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (645, CAST(0x000077D800000000 AS DateTime), NULL, N'Note v1', N'http://cdn.carvalet.com/img/veh/nissan_note_1.png', N'nissan', N'note', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (646, CAST(0x0000834200000000 AS DateTime), CAST(0x0000834200000000 AS DateTime), N'Nv200 v1', N'http://cdn.carvalet.com/img/veh/nissan_nv200_1.png', N'nissan', N'nv200', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (647, CAST(0x000088F700000000 AS DateTime), CAST(0x00008D3F00000000 AS DateTime), N'Pathfinder v1', N'http://cdn.carvalet.com/img/veh/nissan_pathfinder_1.png', N'nissan', N'pathfinder', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (648, CAST(0x000081D500000000 AS DateTime), NULL, N'Patrol v1', N'http://cdn.carvalet.com/img/veh/nissan_patrol_1.png', N'nissan', N'patrol', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (649, CAST(0x0000654C00000000 AS DateTime), NULL, N'Pixo v1', N'http://cdn.carvalet.com/img/veh/nissan_pixo_1.png', N'nissan', N'pixo', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (650, CAST(0x00008A6500000000 AS DateTime), NULL, N'Primera v1', N'http://cdn.carvalet.com/img/veh/nissan_primera_1.png', N'nissan', N'primera', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (651, CAST(0x00008EAC00000000 AS DateTime), CAST(0x0000901A00000000 AS DateTime), N'Pulsar v1', N'http://cdn.carvalet.com/img/veh/nissan_pulsar_1.png', N'nissan', N'pulsar', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (652, CAST(0x00007AB300000000 AS DateTime), NULL, N'Qashqai v1', N'http://cdn.carvalet.com/img/veh/nissan_qashqai_1.png', N'nissan', N'qashqai', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (653, CAST(0x0000806800000000 AS DateTime), NULL, N'Qashqai+2 v1', N'http://cdn.carvalet.com/img/veh/nissan_qashqai+2_1.png', N'nissan', N'qashqai+2', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (654, CAST(0x000088F700000000 AS DateTime), CAST(0x00008BD200000000 AS DateTime), N'Quest v1', N'http://cdn.carvalet.com/img/veh/nissan_quest_1.png', N'nissan', N'quest', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (655, CAST(0x00006B0100000000 AS DateTime), CAST(0x00006C6E00000000 AS DateTime), N'Qx v1', N'http://cdn.carvalet.com/img/veh/nissan_qx_1.png', N'nissan', N'qx', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (656, CAST(0x0000878A00000000 AS DateTime), CAST(0x0000878A00000000 AS DateTime), N'Serena v1', N'http://cdn.carvalet.com/img/veh/nissan_serena_1.png', N'nissan', N'serena', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (657, CAST(0x0000878A00000000 AS DateTime), CAST(0x00008BD200000000 AS DateTime), N'Silvia v1', N'http://cdn.carvalet.com/img/veh/nissan_silvia_1.png', N'nissan', N'silvia', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (658, CAST(0x0000699400000000 AS DateTime), NULL, N'Skyline v1', N'http://cdn.carvalet.com/img/veh/nissan_skyline_1.png', N'nissan', N'skyline', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (659, CAST(0x0000918700000000 AS DateTime), NULL, N'Stagea v1', N'http://cdn.carvalet.com/img/veh/nissan_stagea_1.png', N'nissan', N'stagea', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (660, CAST(0x0000806800000000 AS DateTime), CAST(0x0000861D00000000 AS DateTime), N'Sunny v1', N'http://cdn.carvalet.com/img/veh/nissan_sunny_1.png', N'nissan', N'sunny', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (661, CAST(0x000077D800000000 AS DateTime), NULL, N'Terrano v1', N'http://cdn.carvalet.com/img/veh/nissan_terrano_1.png', N'nissan', N'terrano', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (662, CAST(0x00006C6E00000000 AS DateTime), CAST(0x00006DDC00000000 AS DateTime), N'Tiida v1', N'http://cdn.carvalet.com/img/veh/nissan_tiida_1.png', N'nissan', N'tiida', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (663, CAST(0x0000918700000000 AS DateTime), CAST(0x0000973C00000000 AS DateTime), N'Xterra v1', N'http://cdn.carvalet.com/img/veh/nissan_xterra_1.png', N'nissan', N'xterra', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (664, CAST(0x0000654C00000000 AS DateTime), CAST(0x00006B0100000000 AS DateTime), N'X-Trail v1', N'http://cdn.carvalet.com/img/veh/nissan_x-trail_1.png', N'nissan', N'x-trail', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (665, CAST(0x00008EAC00000000 AS DateTime), NULL, N'M12 v1', N'http://cdn.carvalet.com/img/veh/noble_m12_1.png', N'noble', N'm12', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (666, CAST(0x00008A6500000000 AS DateTime), CAST(0x00008EAC00000000 AS DateTime), N'Astra v1', N'http://cdn.carvalet.com/img/veh/opel_astra_1.png', N'opel', N'astra', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (667, CAST(0x0000722300000000 AS DateTime), CAST(0x0000739100000000 AS DateTime), N'Corsa v1', N'http://cdn.carvalet.com/img/veh/opel_corsa_1.png', N'opel', N'corsa', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (668, CAST(0x00008A6500000000 AS DateTime), NULL, N'Insignia v1', N'http://cdn.carvalet.com/img/veh/opel_insignia_1.png', N'opel', N'insignia', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (669, CAST(0x0000878A00000000 AS DateTime), NULL, N'Manta v1', N'http://cdn.carvalet.com/img/veh/opel_manta_1.png', N'opel', N'manta', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (670, CAST(0x00007AB300000000 AS DateTime), NULL, N'Vectra v1', N'http://cdn.carvalet.com/img/veh/opel_vectra_1.png', N'opel', N'vectra', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (671, CAST(0x0000722300000000 AS DateTime), CAST(0x0000766B00000000 AS DateTime), N'Zafira v1', N'http://cdn.carvalet.com/img/veh/opel_zafira_1.png', N'opel', N'zafira', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (672, CAST(0x00007AB300000000 AS DateTime), NULL, N'Zonda F v1', N'http://cdn.carvalet.com/img/veh/pagani_zonda_f_1.png', N'pagani', N'zonda_f', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (673, CAST(0x00006B0100000000 AS DateTime), NULL, N'Kallista v1', N'http://cdn.carvalet.com/img/veh/panther_kallista_1.png', N'panther', N'kallista', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (674, CAST(0x000066B900000000 AS DateTime), NULL, N'Kelisa v1', N'http://cdn.carvalet.com/img/veh/perodua_kelisa_1.png', N'perodua', N'kelisa', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (675, CAST(0x00006C6E00000000 AS DateTime), NULL, N'Kenari v1', N'http://cdn.carvalet.com/img/veh/perodua_kenari_1.png', N'perodua', N'kenari', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (676, CAST(0x0000806800000000 AS DateTime), CAST(0x0000806800000000 AS DateTime), N'Myvi v1', N'http://cdn.carvalet.com/img/veh/perodua_myvi_1.png', N'perodua', N'myvi', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (677, CAST(0x0000722300000000 AS DateTime), CAST(0x0000739100000000 AS DateTime), N'Nippa v1', N'http://cdn.carvalet.com/img/veh/perodua_nippa_1.png', N'perodua', N'nippa', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (678, CAST(0x000084B000000000 AS DateTime), CAST(0x0000861D00000000 AS DateTime), N'1007 v1', N'http://cdn.carvalet.com/img/veh/peugeot_1007_1.png', N'peugeot', N'1007', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (679, CAST(0x0000918700000000 AS DateTime), NULL, N'106 v1', N'http://cdn.carvalet.com/img/veh/peugeot_106_1.png', N'peugeot', N'106', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (680, CAST(0x000066B900000000 AS DateTime), CAST(0x0000682700000000 AS DateTime), N'107 v1', N'http://cdn.carvalet.com/img/veh/peugeot_107_1.png', N'peugeot', N'107', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (681, CAST(0x0000834200000000 AS DateTime), NULL, N'205 v1', N'http://cdn.carvalet.com/img/veh/peugeot_205_1.png', N'peugeot', N'205', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (682, CAST(0x0000722300000000 AS DateTime), NULL, N'206 v1', N'http://cdn.carvalet.com/img/veh/peugeot_206_1.png', N'peugeot', N'206', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (683, CAST(0x00007C2000000000 AS DateTime), CAST(0x00007C2000000000 AS DateTime), N'207 v1', N'http://cdn.carvalet.com/img/veh/peugeot_207_1.png', N'peugeot', N'207', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (684, CAST(0x00008A6500000000 AS DateTime), NULL, N'3008 v1', N'http://cdn.carvalet.com/img/veh/peugeot_3008_1.png', N'peugeot', N'3008', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (685, CAST(0x0000654C00000000 AS DateTime), NULL, N'305 v1', N'http://cdn.carvalet.com/img/veh/peugeot_305_1.png', N'peugeot', N'305', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (686, CAST(0x000088F700000000 AS DateTime), NULL, N'306 v1', N'http://cdn.carvalet.com/img/veh/peugeot_306_1.png', N'peugeot', N'306', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (687, CAST(0x0000682700000000 AS DateTime), NULL, N'307 v1', N'http://cdn.carvalet.com/img/veh/peugeot_307_1.png', N'peugeot', N'307', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (688, CAST(0x00006F4900000000 AS DateTime), CAST(0x0000722300000000 AS DateTime), N'308 v1', N'http://cdn.carvalet.com/img/veh/peugeot_308_1.png', N'peugeot', N'308', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (689, CAST(0x0000806800000000 AS DateTime), NULL, N'309 v1', N'http://cdn.carvalet.com/img/veh/peugeot_309_1.png', N'peugeot', N'309', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (690, CAST(0x00006B0100000000 AS DateTime), NULL, N'4007 v1', N'http://cdn.carvalet.com/img/veh/peugeot_4007_1.png', N'peugeot', N'4007', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (691, CAST(0x000098A900000000 AS DateTime), NULL, N'405 v1', N'http://cdn.carvalet.com/img/veh/peugeot_405_1.png', N'peugeot', N'405', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (692, CAST(0x000081D500000000 AS DateTime), CAST(0x000081D500000000 AS DateTime), N'406 v1', N'http://cdn.carvalet.com/img/veh/peugeot_406_1.png', N'peugeot', N'406', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (693, CAST(0x00007C2000000000 AS DateTime), CAST(0x00007D8D00000000 AS DateTime), N'407 v1', N'http://cdn.carvalet.com/img/veh/peugeot_407_1.png', N'peugeot', N'407', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (694, CAST(0x000081D500000000 AS DateTime), NULL, N'5008 v1', N'http://cdn.carvalet.com/img/veh/peugeot_5008_1.png', N'peugeot', N'5008', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (695, CAST(0x00007C2000000000 AS DateTime), NULL, N'508 v1', N'http://cdn.carvalet.com/img/veh/peugeot_508_1.png', N'peugeot', N'508', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (696, CAST(0x0000766B00000000 AS DateTime), NULL, N'607 v1', N'http://cdn.carvalet.com/img/veh/peugeot_607_1.png', N'peugeot', N'607', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (697, CAST(0x0000794600000000 AS DateTime), CAST(0x0000794600000000 AS DateTime), N'806 v1', N'http://cdn.carvalet.com/img/veh/peugeot_806_1.png', N'peugeot', N'806', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (698, CAST(0x00007D8D00000000 AS DateTime), NULL, N'807 v1', N'http://cdn.carvalet.com/img/veh/peugeot_807_1.png', N'peugeot', N'807', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (699, CAST(0x00008EAC00000000 AS DateTime), NULL, N'Bipper Tepee v1', N'http://cdn.carvalet.com/img/veh/peugeot_bipper_tepee_1.png', N'peugeot', N'bipper_tepee', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (700, CAST(0x0000682700000000 AS DateTime), NULL, N'Expert Tepee v1', N'http://cdn.carvalet.com/img/veh/peugeot_expert_tepee_1.png', N'peugeot', N'expert_tepee', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (701, CAST(0x00007C2000000000 AS DateTime), CAST(0x00007EFB00000000 AS DateTime), N'Partner Combi v1', N'http://cdn.carvalet.com/img/veh/peugeot_partner_combi_1.png', N'peugeot', N'partner_combi', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (702, CAST(0x0000918700000000 AS DateTime), CAST(0x0000918700000000 AS DateTime), N'Partner Tepee v1', N'http://cdn.carvalet.com/img/veh/peugeot_partner_tepee_1.png', N'peugeot', N'partner_tepee', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (703, CAST(0x00006DDC00000000 AS DateTime), CAST(0x0000722300000000 AS DateTime), N'Rcz v1', N'http://cdn.carvalet.com/img/veh/peugeot_rcz_1.png', N'peugeot', N'rcz', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (704, CAST(0x0000699400000000 AS DateTime), NULL, N'Cuda v1', N'http://cdn.carvalet.com/img/veh/plymouth_cuda_1.png', N'plymouth', N'cuda', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (705, CAST(0x00007AB300000000 AS DateTime), NULL, N'Prowler v1', N'http://cdn.carvalet.com/img/veh/plymouth_prowler_1.png', N'plymouth', N'prowler', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (706, CAST(0x0000682700000000 AS DateTime), NULL, N'Bonneville v1', N'http://cdn.carvalet.com/img/veh/pontiac_bonneville_1.png', N'pontiac', N'bonneville', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (707, CAST(0x0000878A00000000 AS DateTime), CAST(0x00008A6500000000 AS DateTime), N'Firebird v1', N'http://cdn.carvalet.com/img/veh/pontiac_firebird_1.png', N'pontiac', N'firebird', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (708, CAST(0x00008D3F00000000 AS DateTime), NULL, N'Solstice v1', N'http://cdn.carvalet.com/img/veh/pontiac_solstice_1.png', N'pontiac', N'solstice', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (709, CAST(0x0000806800000000 AS DateTime), NULL, N'Trans Am v1', N'http://cdn.carvalet.com/img/veh/pontiac_trans_am_1.png', N'pontiac', N'trans_am', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (710, CAST(0x000074FE00000000 AS DateTime), CAST(0x0000794600000000 AS DateTime), N'356 v1', N'http://cdn.carvalet.com/img/veh/porsche_356_1.png', N'porsche', N'356', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (711, CAST(0x00008EAC00000000 AS DateTime), CAST(0x0000918700000000 AS DateTime), N'911 v1', N'http://cdn.carvalet.com/img/veh/porsche_911_1.png', N'porsche', N'911', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (712, CAST(0x0000654C00000000 AS DateTime), CAST(0x000066B900000000 AS DateTime), N'911 [991] v1', N'http://cdn.carvalet.com/img/veh/porsche_911_[991]_1.png', N'porsche', N'911_[991]', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (713, CAST(0x000098A900000000 AS DateTime), CAST(0x00009E5E00000000 AS DateTime), N'911 Gt2 v1', N'http://cdn.carvalet.com/img/veh/porsche_911_gt2_1.png', N'porsche', N'911_gt2', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (714, CAST(0x0000699400000000 AS DateTime), CAST(0x00006C6E00000000 AS DateTime), N'911 Gt3 v1', N'http://cdn.carvalet.com/img/veh/porsche_911_gt3_1.png', N'porsche', N'911_gt3', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (715, CAST(0x0000834200000000 AS DateTime), CAST(0x0000834200000000 AS DateTime), N'911 Turbo v1', N'http://cdn.carvalet.com/img/veh/porsche_911_turbo_1.png', N'porsche', N'911_turbo', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (716, CAST(0x0000766B00000000 AS DateTime), NULL, N'924 v1', N'http://cdn.carvalet.com/img/veh/porsche_924_1.png', N'porsche', N'924', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (717, CAST(0x00008D3F00000000 AS DateTime), NULL, N'928 v1', N'http://cdn.carvalet.com/img/veh/porsche_928_1.png', N'porsche', N'928', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (718, CAST(0x000077D800000000 AS DateTime), NULL, N'944 v1', N'http://cdn.carvalet.com/img/veh/porsche_944_1.png', N'porsche', N'944', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (719, CAST(0x0000699400000000 AS DateTime), NULL, N'968 v1', N'http://cdn.carvalet.com/img/veh/porsche_968_1.png', N'porsche', N'968', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (720, CAST(0x000081D500000000 AS DateTime), NULL, N'Boxster v1', N'http://cdn.carvalet.com/img/veh/porsche_boxster_1.png', N'porsche', N'boxster', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (721, CAST(0x000088F700000000 AS DateTime), CAST(0x00008EAC00000000 AS DateTime), N'Carrera Gt v1', N'http://cdn.carvalet.com/img/veh/porsche_carrera_gt_1.png', N'porsche', N'carrera_gt', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (722, CAST(0x000084B000000000 AS DateTime), NULL, N'Cayenne v1', N'http://cdn.carvalet.com/img/veh/porsche_cayenne_1.png', N'porsche', N'cayenne', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (723, CAST(0x00006DDC00000000 AS DateTime), CAST(0x0000722300000000 AS DateTime), N'Cayman v1', N'http://cdn.carvalet.com/img/veh/porsche_cayman_1.png', N'porsche', N'cayman', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (724, CAST(0x0000699400000000 AS DateTime), NULL, N'Panamera v1', N'http://cdn.carvalet.com/img/veh/porsche_panamera_1.png', N'porsche', N'panamera', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (725, CAST(0x00008A6500000000 AS DateTime), NULL, N'Gen-2 v1', N'http://cdn.carvalet.com/img/veh/proton_gen-2_1.png', N'proton', N'gen-2', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (726, CAST(0x00007D8D00000000 AS DateTime), CAST(0x000081D500000000 AS DateTime), N'Impian v1', N'http://cdn.carvalet.com/img/veh/proton_impian_1.png', N'proton', N'impian', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (727, CAST(0x000098A900000000 AS DateTime), NULL, N'Jumbuck v1', N'http://cdn.carvalet.com/img/veh/proton_jumbuck_1.png', N'proton', N'jumbuck', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (728, CAST(0x00007AB300000000 AS DateTime), NULL, N'Persona v1', N'http://cdn.carvalet.com/img/veh/proton_persona_1.png', N'proton', N'persona', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (729, CAST(0x000074FE00000000 AS DateTime), CAST(0x000074FE00000000 AS DateTime), N'Satria v1', N'http://cdn.carvalet.com/img/veh/proton_satria_1.png', N'proton', N'satria', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (730, CAST(0x0000766B00000000 AS DateTime), NULL, N'Satria Neo v1', N'http://cdn.carvalet.com/img/veh/proton_satria_neo_1.png', N'proton', N'satria_neo', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (731, CAST(0x00006B0100000000 AS DateTime), CAST(0x00006DDC00000000 AS DateTime), N'Savvy v1', N'http://cdn.carvalet.com/img/veh/proton_savvy_1.png', N'proton', N'savvy', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (732, CAST(0x0000722300000000 AS DateTime), CAST(0x0000739100000000 AS DateTime), N'Wira v1', N'http://cdn.carvalet.com/img/veh/proton_wira_1.png', N'proton', N'wira', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (733, CAST(0x000088F700000000 AS DateTime), NULL, N'Sr3 v1', N'http://cdn.carvalet.com/img/veh/radical_sr3_1.png', N'radical', N'sr3', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (734, CAST(0x0000946100000000 AS DateTime), CAST(0x0000973C00000000 AS DateTime), N'Rialto v1', N'http://cdn.carvalet.com/img/veh/reliant_rialto_1.png', N'reliant', N'rialto', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (735, CAST(0x000066B900000000 AS DateTime), CAST(0x0000682700000000 AS DateTime), N'Robin v1', N'http://cdn.carvalet.com/img/veh/reliant_robin_1.png', N'reliant', N'robin', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (736, CAST(0x0000722300000000 AS DateTime), CAST(0x0000766B00000000 AS DateTime), N'Scimitar v1', N'http://cdn.carvalet.com/img/veh/reliant_scimitar_1.png', N'reliant', N'scimitar', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (737, CAST(0x00008A6500000000 AS DateTime), NULL, N'11 v1', N'http://cdn.carvalet.com/img/veh/renault_11_1.png', N'renault', N'11', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (738, CAST(0x000098A900000000 AS DateTime), NULL, N'19 v1', N'http://cdn.carvalet.com/img/veh/renault_19_1.png', N'renault', N'19', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (739, CAST(0x0000861D00000000 AS DateTime), CAST(0x0000878A00000000 AS DateTime), N'21 v1', N'http://cdn.carvalet.com/img/veh/renault_21_1.png', N'renault', N'21', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (740, CAST(0x0000739100000000 AS DateTime), CAST(0x000077D800000000 AS DateTime), N'5 v1', N'http://cdn.carvalet.com/img/veh/renault_5_1.png', N'renault', N'5', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (741, CAST(0x000088F700000000 AS DateTime), NULL, N'Avantime v1', N'http://cdn.carvalet.com/img/veh/renault_avantime_1.png', N'renault', N'avantime', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (742, CAST(0x000070B600000000 AS DateTime), NULL, N'Caravelle v1', N'http://cdn.carvalet.com/img/veh/renault_caravelle_1.png', N'renault', N'caravelle', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (743, CAST(0x0000861D00000000 AS DateTime), NULL, N'Clio v1', N'http://cdn.carvalet.com/img/veh/renault_clio_1.png', N'renault', N'clio', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (744, CAST(0x000070B600000000 AS DateTime), CAST(0x000070B600000000 AS DateTime), N'Espace v1', N'http://cdn.carvalet.com/img/veh/renault_espace_1.png', N'renault', N'espace', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (745, CAST(0x00008A6500000000 AS DateTime), NULL, N'Grand Espace v1', N'http://cdn.carvalet.com/img/veh/renault_grand_espace_1.png', N'renault', N'grand_espace', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (746, CAST(0x00007AB300000000 AS DateTime), CAST(0x00007D8D00000000 AS DateTime), N'Grand Modus v1', N'http://cdn.carvalet.com/img/veh/renault_grand_modus_1.png', N'renault', N'grand_modus', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (747, CAST(0x0000878A00000000 AS DateTime), CAST(0x000088F700000000 AS DateTime), N'Grand Scenic v1', N'http://cdn.carvalet.com/img/veh/renault_grand_scenic_1.png', N'renault', N'grand_scenic', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (748, CAST(0x00006B0100000000 AS DateTime), NULL, N'Gta v1', N'http://cdn.carvalet.com/img/veh/renault_gta_1.png', N'renault', N'gta', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (749, CAST(0x000092F400000000 AS DateTime), NULL, N'Kangoo v1', N'http://cdn.carvalet.com/img/veh/renault_kangoo_1.png', N'renault', N'kangoo', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (750, CAST(0x00006B0100000000 AS DateTime), NULL, N'Koleos v1', N'http://cdn.carvalet.com/img/veh/renault_koleos_1.png', N'renault', N'koleos', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (751, CAST(0x00008A6500000000 AS DateTime), CAST(0x00008D3F00000000 AS DateTime), N'Laguna v1', N'http://cdn.carvalet.com/img/veh/renault_laguna_1.png', N'renault', N'laguna', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (752, CAST(0x000077D800000000 AS DateTime), CAST(0x00007AB300000000 AS DateTime), N'Megane v1', N'http://cdn.carvalet.com/img/veh/renault_megane_1.png', N'renault', N'megane', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (753, CAST(0x0000901A00000000 AS DateTime), CAST(0x000095CF00000000 AS DateTime), N'Megane Scenic v1', N'http://cdn.carvalet.com/img/veh/renault_megane_scenic_1.png', N'renault', N'megane_scenic', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (754, CAST(0x0000973C00000000 AS DateTime), CAST(0x00009CF100000000 AS DateTime), N'Modus v1', N'http://cdn.carvalet.com/img/veh/renault_modus_1.png', N'renault', N'modus', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (755, CAST(0x00008A6500000000 AS DateTime), CAST(0x00008D3F00000000 AS DateTime), N'Safrane v1', N'http://cdn.carvalet.com/img/veh/renault_safrane_1.png', N'renault', N'safrane', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (756, CAST(0x00008BD200000000 AS DateTime), NULL, N'Scenic v1', N'http://cdn.carvalet.com/img/veh/renault_scenic_1.png', N'renault', N'scenic', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (757, CAST(0x0000918700000000 AS DateTime), NULL, N'Sport Spider v1', N'http://cdn.carvalet.com/img/veh/renault_sport_spider_1.png', N'renault', N'sport_spider', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (758, CAST(0x0000699400000000 AS DateTime), NULL, N'Twingo v1', N'http://cdn.carvalet.com/img/veh/renault_twingo_1.png', N'renault', N'twingo', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (759, CAST(0x0000766B00000000 AS DateTime), NULL, N'Vel Satis v1', N'http://cdn.carvalet.com/img/veh/renault_vel_satis_1.png', N'renault', N'vel_satis', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (760, CAST(0x00008BD200000000 AS DateTime), NULL, N'Wind v1', N'http://cdn.carvalet.com/img/veh/renault_wind_1.png', N'renault', N'wind', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (761, CAST(0x00008A6500000000 AS DateTime), CAST(0x00008BD200000000 AS DateTime), N'G-Wiz v1', N'http://cdn.carvalet.com/img/veh/reva_g-wiz_1.png', N'reva', N'g-wiz', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (762, CAST(0x000066B900000000 AS DateTime), CAST(0x0000699400000000 AS DateTime), N'1.5 v1', N'http://cdn.carvalet.com/img/veh/riley_1.5_1.png', N'riley', N'1.5', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (763, CAST(0x00007D8D00000000 AS DateTime), NULL, N'20/25 v1', N'http://cdn.carvalet.com/img/veh/rolls-royce_20]]25_1.png', N'rolls-royce', N'20]]25', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (764, CAST(0x000070B600000000 AS DateTime), CAST(0x0000722300000000 AS DateTime), N'Corniche v1', N'http://cdn.carvalet.com/img/veh/rolls-royce_corniche_1.png', N'rolls-royce', N'corniche', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (765, CAST(0x000066B900000000 AS DateTime), CAST(0x000066B900000000 AS DateTime), N'Ghost v1', N'http://cdn.carvalet.com/img/veh/rolls-royce_ghost_1.png', N'rolls-royce', N'ghost', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (766, CAST(0x000098A900000000 AS DateTime), NULL, N'Phantom v1', N'http://cdn.carvalet.com/img/veh/rolls-royce_phantom_1.png', N'rolls-royce', N'phantom', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (767, CAST(0x00007D8D00000000 AS DateTime), CAST(0x0000806800000000 AS DateTime), N'Silver Cloud v1', N'http://cdn.carvalet.com/img/veh/rolls-royce_silver_cloud_1.png', N'rolls-royce', N'silver_cloud', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (768, CAST(0x0000699400000000 AS DateTime), CAST(0x00006F4900000000 AS DateTime), N'Silver Dawn v1', N'http://cdn.carvalet.com/img/veh/rolls-royce_silver_dawn_1.png', N'rolls-royce', N'silver_dawn', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (769, CAST(0x00006B0100000000 AS DateTime), NULL, N'Silver Ghost v1', N'http://cdn.carvalet.com/img/veh/rolls-royce_silver_ghost_1.png', N'rolls-royce', N'silver_ghost', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (770, CAST(0x000077D800000000 AS DateTime), CAST(0x000077D800000000 AS DateTime), N'Silver Seraph v1', N'http://cdn.carvalet.com/img/veh/rolls-royce_silver_seraph_1.png', N'rolls-royce', N'silver_seraph', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (771, CAST(0x00007EFB00000000 AS DateTime), NULL, N'Silver Shadow v1', N'http://cdn.carvalet.com/img/veh/rolls-royce_silver_shadow_1.png', N'rolls-royce', N'silver_shadow', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (772, CAST(0x0000946100000000 AS DateTime), NULL, N'Silver Spirit v1', N'http://cdn.carvalet.com/img/veh/rolls-royce_silver_spirit_1.png', N'rolls-royce', N'silver_spirit', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (773, CAST(0x00006B0100000000 AS DateTime), NULL, N'Silver Spur v1', N'http://cdn.carvalet.com/img/veh/rolls-royce_silver_spur_1.png', N'rolls-royce', N'silver_spur', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (774, CAST(0x0000946100000000 AS DateTime), CAST(0x000098A900000000 AS DateTime), N'Silver Wraith v1', N'http://cdn.carvalet.com/img/veh/rolls-royce_silver_wraith_1.png', N'rolls-royce', N'silver_wraith', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (775, CAST(0x00007D8D00000000 AS DateTime), NULL, N'100 v1', N'http://cdn.carvalet.com/img/veh/rover_100_1.png', N'rover', N'100', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (776, CAST(0x000077D800000000 AS DateTime), NULL, N'200 v1', N'http://cdn.carvalet.com/img/veh/rover_200_1.png', N'rover', N'200', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (777, CAST(0x0000699400000000 AS DateTime), NULL, N'2200 v1', N'http://cdn.carvalet.com/img/veh/rover_2200_1.png', N'rover', N'2200', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (778, CAST(0x00007C2000000000 AS DateTime), CAST(0x00007D8D00000000 AS DateTime), N'25 v1', N'http://cdn.carvalet.com/img/veh/rover_25_1.png', N'rover', N'25', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (779, CAST(0x000088F700000000 AS DateTime), CAST(0x00008D3F00000000 AS DateTime), N'400 v1', N'http://cdn.carvalet.com/img/veh/rover_400_1.png', N'rover', N'400', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (780, CAST(0x00008EAC00000000 AS DateTime), CAST(0x000092F400000000 AS DateTime), N'45 v1', N'http://cdn.carvalet.com/img/veh/rover_45_1.png', N'rover', N'45', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (781, CAST(0x000066B900000000 AS DateTime), CAST(0x00006B0100000000 AS DateTime), N'600 v1', N'http://cdn.carvalet.com/img/veh/rover_600_1.png', N'rover', N'600', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (782, CAST(0x0000973C00000000 AS DateTime), NULL, N'75 v1', N'http://cdn.carvalet.com/img/veh/rover_75_1.png', N'rover', N'75', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (783, CAST(0x0000878A00000000 AS DateTime), CAST(0x00008BD200000000 AS DateTime), N'800 v1', N'http://cdn.carvalet.com/img/veh/rover_800_1.png', N'rover', N'800', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (784, CAST(0x000063DF00000000 AS DateTime), CAST(0x0000699400000000 AS DateTime), N'Cabriolet v1', N'http://cdn.carvalet.com/img/veh/rover_cabriolet_1.png', N'rover', N'cabriolet', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (785, CAST(0x0000806800000000 AS DateTime), CAST(0x0000806800000000 AS DateTime), N'City Rover v1', N'http://cdn.carvalet.com/img/veh/rover_city_rover_1.png', N'rover', N'city_rover', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (786, CAST(0x0000682700000000 AS DateTime), CAST(0x00006C6E00000000 AS DateTime), N'Coupe v1', N'http://cdn.carvalet.com/img/veh/rover_coupe_1.png', N'rover', N'coupe', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (787, CAST(0x0000834200000000 AS DateTime), CAST(0x000088F700000000 AS DateTime), N'Metro v1', N'http://cdn.carvalet.com/img/veh/rover_metro_1.png', N'rover', N'metro', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (788, CAST(0x0000739100000000 AS DateTime), NULL, N'Mini v1', N'http://cdn.carvalet.com/img/veh/rover_mini_1.png', N'rover', N'mini', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (789, CAST(0x000098A900000000 AS DateTime), NULL, N'P5 v1', N'http://cdn.carvalet.com/img/veh/rover_p5_1.png', N'rover', N'p5', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (790, CAST(0x000066B900000000 AS DateTime), CAST(0x000066B900000000 AS DateTime), N'Sterling v1', N'http://cdn.carvalet.com/img/veh/rover_sterling_1.png', N'rover', N'sterling', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (791, CAST(0x0000794600000000 AS DateTime), NULL, N'Streetwise v1', N'http://cdn.carvalet.com/img/veh/rover_streetwise_1.png', N'rover', N'streetwise', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (792, CAST(0x0000946100000000 AS DateTime), CAST(0x000098A900000000 AS DateTime), N'Tourer v1', N'http://cdn.carvalet.com/img/veh/rover_tourer_1.png', N'rover', N'tourer', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (793, CAST(0x00006DDC00000000 AS DateTime), CAST(0x00006F4900000000 AS DateTime), N'900 v1', N'http://cdn.carvalet.com/img/veh/saab_900_1.png', N'saab', N'900', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (794, CAST(0x000074FE00000000 AS DateTime), NULL, N'9000 v1', N'http://cdn.carvalet.com/img/veh/saab_9000_1.png', N'saab', N'9000', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (795, CAST(0x0000973C00000000 AS DateTime), CAST(0x0000973C00000000 AS DateTime), N'9-3 v1', N'http://cdn.carvalet.com/img/veh/saab_9-3_1.png', N'saab', N'9-3', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (796, CAST(0x0000918700000000 AS DateTime), CAST(0x000092F400000000 AS DateTime), N'9-3X v1', N'http://cdn.carvalet.com/img/veh/saab_9-3x_1.png', N'saab', N'9-3x', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (797, CAST(0x000063DF00000000 AS DateTime), NULL, N'9-5 v1', N'http://cdn.carvalet.com/img/veh/saab_9-5_1.png', N'saab', N'9-5', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (798, CAST(0x0000946100000000 AS DateTime), NULL, N'Ps10 v1', N'http://cdn.carvalet.com/img/veh/santana_ps10_1.png', N'santana', N'ps10', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (799, CAST(0x000063DF00000000 AS DateTime), NULL, N'Alhambra v1', N'http://cdn.carvalet.com/img/veh/seat_alhambra_1.png', N'seat', N'alhambra', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (800, CAST(0x00007D8D00000000 AS DateTime), CAST(0x00007EFB00000000 AS DateTime), N'Altea v1', N'http://cdn.carvalet.com/img/veh/seat_altea_1.png', N'seat', N'altea', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (801, CAST(0x00007D8D00000000 AS DateTime), CAST(0x00007EFB00000000 AS DateTime), N'Altea Freetrack 4 v1', N'http://cdn.carvalet.com/img/veh/seat_altea_freetrack_4_1.png', N'seat', N'altea_freetrack_4', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (802, CAST(0x00006C6E00000000 AS DateTime), NULL, N'Altea Xl v1', N'http://cdn.carvalet.com/img/veh/seat_altea_xl_1.png', N'seat', N'altea_xl', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (803, CAST(0x000084B000000000 AS DateTime), NULL, N'Arosa v1', N'http://cdn.carvalet.com/img/veh/seat_arosa_1.png', N'seat', N'arosa', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (804, CAST(0x0000722300000000 AS DateTime), CAST(0x0000739100000000 AS DateTime), N'Cordoba v1', N'http://cdn.carvalet.com/img/veh/seat_cordoba_1.png', N'seat', N'cordoba', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (805, CAST(0x000098A900000000 AS DateTime), CAST(0x00009A1600000000 AS DateTime), N'Exeo v1', N'http://cdn.carvalet.com/img/veh/seat_exeo_1.png', N'seat', N'exeo', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (806, CAST(0x000070B600000000 AS DateTime), CAST(0x000070B600000000 AS DateTime), N'Ibiza v1', N'http://cdn.carvalet.com/img/veh/seat_ibiza_1.png', N'seat', N'ibiza', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (807, CAST(0x0000901A00000000 AS DateTime), NULL, N'Leon v1', N'http://cdn.carvalet.com/img/veh/seat_leon_1.png', N'seat', N'leon', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (808, CAST(0x000098A900000000 AS DateTime), NULL, N'Marbella v1', N'http://cdn.carvalet.com/img/veh/seat_marbella_1.png', N'seat', N'marbella', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (809, CAST(0x0000946100000000 AS DateTime), NULL, N'Toledo v1', N'http://cdn.carvalet.com/img/veh/seat_toledo_1.png', N'seat', N'toledo', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (810, CAST(0x0000973C00000000 AS DateTime), NULL, N'Vogue v1', N'http://cdn.carvalet.com/img/veh/singer_vogue_1.png', N'singer', N'vogue', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (811, CAST(0x00007EFB00000000 AS DateTime), NULL, N'Fabia v1', N'http://cdn.carvalet.com/img/veh/skoda_fabia_1.png', N'skoda', N'fabia', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (812, CAST(0x0000901A00000000 AS DateTime), CAST(0x0000918700000000 AS DateTime), N'Favorit v1', N'http://cdn.carvalet.com/img/veh/skoda_favorit_1.png', N'skoda', N'favorit', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (813, CAST(0x000098A900000000 AS DateTime), NULL, N'Felicia v1', N'http://cdn.carvalet.com/img/veh/skoda_felicia_1.png', N'skoda', N'felicia', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (814, CAST(0x00006F4900000000 AS DateTime), NULL, N'Octavia v1', N'http://cdn.carvalet.com/img/veh/skoda_octavia_1.png', N'skoda', N'octavia', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (815, CAST(0x0000654C00000000 AS DateTime), CAST(0x000066B900000000 AS DateTime), N'Roomster v1', N'http://cdn.carvalet.com/img/veh/skoda_roomster_1.png', N'skoda', N'roomster', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (816, CAST(0x0000901A00000000 AS DateTime), NULL, N'Superb v1', N'http://cdn.carvalet.com/img/veh/skoda_superb_1.png', N'skoda', N'superb', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (817, CAST(0x00007EFB00000000 AS DateTime), CAST(0x00007EFB00000000 AS DateTime), N'Yeti v1', N'http://cdn.carvalet.com/img/veh/skoda_yeti_1.png', N'skoda', N'yeti', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (818, CAST(0x0000794600000000 AS DateTime), CAST(0x00007D8D00000000 AS DateTime), N'City-Cabriolet v1', N'http://cdn.carvalet.com/img/veh/smart_city-cabriolet_1.png', N'smart', N'city-cabriolet', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (819, CAST(0x00007EFB00000000 AS DateTime), CAST(0x0000834200000000 AS DateTime), N'City-Coupe v1', N'http://cdn.carvalet.com/img/veh/smart_city-coupe_1.png', N'smart', N'city-coupe', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (820, CAST(0x0000946100000000 AS DateTime), CAST(0x00009A1600000000 AS DateTime), N'Forfour v1', N'http://cdn.carvalet.com/img/veh/smart_forfour_1.png', N'smart', N'forfour', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (821, CAST(0x00006DDC00000000 AS DateTime), NULL, N'Fortwo v1', N'http://cdn.carvalet.com/img/veh/smart_fortwo_1.png', N'smart', N'fortwo', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (822, CAST(0x00007D8D00000000 AS DateTime), CAST(0x00007EFB00000000 AS DateTime), N'Roadster v1', N'http://cdn.carvalet.com/img/veh/smart_roadster_1.png', N'smart', N'roadster', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (823, CAST(0x00006DDC00000000 AS DateTime), CAST(0x000070B600000000 AS DateTime), N'Roadster-Coupe v1', N'http://cdn.carvalet.com/img/veh/smart_roadster-coupe_1.png', N'smart', N'roadster-coupe', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (824, CAST(0x0000861D00000000 AS DateTime), NULL, N'C8 Spyder v1', N'http://cdn.carvalet.com/img/veh/spyker_c8_spyder_1.png', N'spyker', N'c8_spyder', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (825, CAST(0x00008D3F00000000 AS DateTime), NULL, N'Actyon v1', N'http://cdn.carvalet.com/img/veh/ssangyong_actyon_1.png', N'ssangyong', N'actyon', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (826, CAST(0x0000946100000000 AS DateTime), NULL, N'Korando v1', N'http://cdn.carvalet.com/img/veh/ssangyong_korando_1.png', N'ssangyong', N'korando', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (827, CAST(0x000066B900000000 AS DateTime), NULL, N'Kyron v1', N'http://cdn.carvalet.com/img/veh/ssangyong_kyron_1.png', N'ssangyong', N'kyron', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (828, CAST(0x00006DDC00000000 AS DateTime), CAST(0x00006DDC00000000 AS DateTime), N'Musso v1', N'http://cdn.carvalet.com/img/veh/ssangyong_musso_1.png', N'ssangyong', N'musso', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (829, CAST(0x0000699400000000 AS DateTime), NULL, N'Rexton v1', N'http://cdn.carvalet.com/img/veh/ssangyong_rexton_1.png', N'ssangyong', N'rexton', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (830, CAST(0x000088F700000000 AS DateTime), NULL, N'Rodius v1', N'http://cdn.carvalet.com/img/veh/ssangyong_rodius_1.png', N'ssangyong', N'rodius', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (831, CAST(0x0000794600000000 AS DateTime), CAST(0x00007C2000000000 AS DateTime), N'Forester v1', N'http://cdn.carvalet.com/img/veh/subaru_forester_1.png', N'subaru', N'forester', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (832, CAST(0x000095CF00000000 AS DateTime), CAST(0x0000973C00000000 AS DateTime), N'Impreza v1', N'http://cdn.carvalet.com/img/veh/subaru_impreza_1.png', N'subaru', N'impreza', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (833, CAST(0x000070B600000000 AS DateTime), NULL, N'Justy v1', N'http://cdn.carvalet.com/img/veh/subaru_justy_1.png', N'subaru', N'justy', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (834, CAST(0x000095CF00000000 AS DateTime), NULL, N'Legacy v1', N'http://cdn.carvalet.com/img/veh/subaru_legacy_1.png', N'subaru', N'legacy', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (835, CAST(0x00007AB300000000 AS DateTime), NULL, N'Outback v1', N'http://cdn.carvalet.com/img/veh/subaru_outback_1.png', N'subaru', N'outback', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (836, CAST(0x000088F700000000 AS DateTime), NULL, N'Svx v1', N'http://cdn.carvalet.com/img/veh/subaru_svx_1.png', N'subaru', N'svx', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (837, CAST(0x0000806800000000 AS DateTime), CAST(0x0000806800000000 AS DateTime), N'Tribeca v1', N'http://cdn.carvalet.com/img/veh/subaru_tribeca_1.png', N'subaru', N'tribeca', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (838, CAST(0x00006DDC00000000 AS DateTime), NULL, N'Wrx Sti v1', N'http://cdn.carvalet.com/img/veh/subaru_wrx_sti_1.png', N'subaru', N'wrx_sti', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (839, CAST(0x00007D8D00000000 AS DateTime), CAST(0x0000834200000000 AS DateTime), N'Xv v1', N'http://cdn.carvalet.com/img/veh/subaru_xv_1.png', N'subaru', N'xv', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (840, CAST(0x0000739100000000 AS DateTime), NULL, N'Alto v1', N'http://cdn.carvalet.com/img/veh/suzuki_alto_1.png', N'suzuki', N'alto', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (841, CAST(0x000088F700000000 AS DateTime), NULL, N'Baleno v1', N'http://cdn.carvalet.com/img/veh/suzuki_baleno_1.png', N'suzuki', N'baleno', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (842, CAST(0x00008BD200000000 AS DateTime), CAST(0x00008EAC00000000 AS DateTime), N'Cappuccino v1', N'http://cdn.carvalet.com/img/veh/suzuki_cappuccino_1.png', N'suzuki', N'cappuccino', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (843, CAST(0x000092F400000000 AS DateTime), NULL, N'Grand Vitara v1', N'http://cdn.carvalet.com/img/veh/suzuki_grand_vitara_1.png', N'suzuki', N'grand_vitara', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (844, CAST(0x0000861D00000000 AS DateTime), CAST(0x0000878A00000000 AS DateTime), N'Ignis v1', N'http://cdn.carvalet.com/img/veh/suzuki_ignis_1.png', N'suzuki', N'ignis', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (845, CAST(0x0000682700000000 AS DateTime), NULL, N'Jimny v1', N'http://cdn.carvalet.com/img/veh/suzuki_jimny_1.png', N'suzuki', N'jimny', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (846, CAST(0x00008EAC00000000 AS DateTime), NULL, N'Kizashi v1', N'http://cdn.carvalet.com/img/veh/suzuki_kizashi_1.png', N'suzuki', N'kizashi', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (847, CAST(0x0000878A00000000 AS DateTime), NULL, N'Liana v1', N'http://cdn.carvalet.com/img/veh/suzuki_liana_1.png', N'suzuki', N'liana', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (848, CAST(0x0000794600000000 AS DateTime), CAST(0x00007EFB00000000 AS DateTime), N'Sa v1', N'http://cdn.carvalet.com/img/veh/suzuki_sa_1.png', N'suzuki', N'sa', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (849, CAST(0x00006C6E00000000 AS DateTime), NULL, N'Samurai v1', N'http://cdn.carvalet.com/img/veh/suzuki_samurai_1.png', N'suzuki', N'samurai', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (850, CAST(0x000092F400000000 AS DateTime), NULL, N'Sj v1', N'http://cdn.carvalet.com/img/veh/suzuki_sj_1.png', N'suzuki', N'sj', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (851, CAST(0x0000654C00000000 AS DateTime), CAST(0x0000682700000000 AS DateTime), N'Splash v1', N'http://cdn.carvalet.com/img/veh/suzuki_splash_1.png', N'suzuki', N'splash', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (852, CAST(0x000098A900000000 AS DateTime), NULL, N'Swift v1', N'http://cdn.carvalet.com/img/veh/suzuki_swift_1.png', N'suzuki', N'swift', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (853, CAST(0x0000654C00000000 AS DateTime), CAST(0x0000682700000000 AS DateTime), N'Sx4 v1', N'http://cdn.carvalet.com/img/veh/suzuki_sx4_1.png', N'suzuki', N'sx4', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (854, CAST(0x0000834200000000 AS DateTime), NULL, N'Vitara v1', N'http://cdn.carvalet.com/img/veh/suzuki_vitara_1.png', N'suzuki', N'vitara', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (855, CAST(0x000063DF00000000 AS DateTime), CAST(0x0000699400000000 AS DateTime), N'Wagon R v1', N'http://cdn.carvalet.com/img/veh/suzuki_wagon_r_1.png', N'suzuki', N'wagon_r', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (856, CAST(0x0000806800000000 AS DateTime), NULL, N'X-90 v1', N'http://cdn.carvalet.com/img/veh/suzuki_x-90_1.png', N'suzuki', N'x-90', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (857, CAST(0x0000861D00000000 AS DateTime), CAST(0x0000861D00000000 AS DateTime), N'Alpine v1', N'http://cdn.carvalet.com/img/veh/talbot_alpine_1.png', N'talbot', N'alpine', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (858, CAST(0x00008D3F00000000 AS DateTime), NULL, N'Safari v1', N'http://cdn.carvalet.com/img/veh/tata_safari_1.png', N'tata', N'safari', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (859, CAST(0x00007D8D00000000 AS DateTime), CAST(0x0000834200000000 AS DateTime), N'Avon v1', N'http://cdn.carvalet.com/img/veh/tiger_avon_1.png', N'tiger', N'avon', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (860, CAST(0x000095CF00000000 AS DateTime), CAST(0x000098A900000000 AS DateTime), N'1000 v1', N'http://cdn.carvalet.com/img/veh/toyota_1000_1.png', N'toyota', N'1000', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (861, CAST(0x000098A900000000 AS DateTime), NULL, N'4-Runner v1', N'http://cdn.carvalet.com/img/veh/toyota_4-runner_1.png', N'toyota', N'4-runner', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (862, CAST(0x0000654C00000000 AS DateTime), NULL, N'Alphard v1', N'http://cdn.carvalet.com/img/veh/toyota_alphard_1.png', N'toyota', N'alphard', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (863, CAST(0x00006B0100000000 AS DateTime), CAST(0x000070B600000000 AS DateTime), N'Altezza v1', N'http://cdn.carvalet.com/img/veh/toyota_altezza_1.png', N'toyota', N'altezza', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (864, CAST(0x00006DDC00000000 AS DateTime), NULL, N'Aristo v1', N'http://cdn.carvalet.com/img/veh/toyota_aristo_1.png', N'toyota', N'aristo', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (865, CAST(0x0000794600000000 AS DateTime), NULL, N'Auris v1', N'http://cdn.carvalet.com/img/veh/toyota_auris_1.png', N'toyota', N'auris', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (866, CAST(0x000092F400000000 AS DateTime), NULL, N'Avensis v1', N'http://cdn.carvalet.com/img/veh/toyota_avensis_1.png', N'toyota', N'avensis', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (867, CAST(0x000084B000000000 AS DateTime), CAST(0x000088F700000000 AS DateTime), N'Avensis Verso v1', N'http://cdn.carvalet.com/img/veh/toyota_avensis_verso_1.png', N'toyota', N'avensis_verso', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (868, CAST(0x00007EFB00000000 AS DateTime), CAST(0x0000834200000000 AS DateTime), N'Aygo v1', N'http://cdn.carvalet.com/img/veh/toyota_aygo_1.png', N'toyota', N'aygo', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (869, CAST(0x0000654C00000000 AS DateTime), CAST(0x0000699400000000 AS DateTime), N'Bb v1', N'http://cdn.carvalet.com/img/veh/toyota_bb_1.png', N'toyota', N'bb', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (870, CAST(0x00006F4900000000 AS DateTime), NULL, N'Camry v1', N'http://cdn.carvalet.com/img/veh/toyota_camry_1.png', N'toyota', N'camry', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (871, CAST(0x00008EAC00000000 AS DateTime), CAST(0x000092F400000000 AS DateTime), N'Carina v1', N'http://cdn.carvalet.com/img/veh/toyota_carina_1.png', N'toyota', N'carina', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (872, CAST(0x000081D500000000 AS DateTime), NULL, N'Celica v1', N'http://cdn.carvalet.com/img/veh/toyota_celica_1.png', N'toyota', N'celica', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (873, CAST(0x0000794600000000 AS DateTime), CAST(0x00007C2000000000 AS DateTime), N'Corolla v1', N'http://cdn.carvalet.com/img/veh/toyota_corolla_1.png', N'toyota', N'corolla', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (874, CAST(0x000070B600000000 AS DateTime), CAST(0x000070B600000000 AS DateTime), N'Corolla Verso v1', N'http://cdn.carvalet.com/img/veh/toyota_corolla_verso_1.png', N'toyota', N'corolla_verso', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (875, CAST(0x00006B0100000000 AS DateTime), CAST(0x00006F4900000000 AS DateTime), N'Crown v1', N'http://cdn.carvalet.com/img/veh/toyota_crown_1.png', N'toyota', N'crown', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (876, CAST(0x00006C6E00000000 AS DateTime), NULL, N'Emina v1', N'http://cdn.carvalet.com/img/veh/toyota_emina_1.png', N'toyota', N'emina', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (877, CAST(0x0000794600000000 AS DateTime), CAST(0x00007EFB00000000 AS DateTime), N'Estima v1', N'http://cdn.carvalet.com/img/veh/toyota_estima_1.png', N'toyota', N'estima', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (878, CAST(0x00008D3F00000000 AS DateTime), NULL, N'Granvia v1', N'http://cdn.carvalet.com/img/veh/toyota_granvia_1.png', N'toyota', N'granvia', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (879, CAST(0x00006C6E00000000 AS DateTime), CAST(0x00006C6E00000000 AS DateTime), N'Hiace v1', N'http://cdn.carvalet.com/img/veh/toyota_hiace_1.png', N'toyota', N'hiace', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (880, CAST(0x0000654C00000000 AS DateTime), NULL, N'Hilux v1', N'http://cdn.carvalet.com/img/veh/toyota_hilux_1.png', N'toyota', N'hilux', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (881, CAST(0x00006B0100000000 AS DateTime), NULL, N'Iq v1', N'http://cdn.carvalet.com/img/veh/toyota_iq_1.png', N'toyota', N'iq', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (882, CAST(0x00006B0100000000 AS DateTime), NULL, N'Landcruiser v1', N'http://cdn.carvalet.com/img/veh/toyota_landcruiser_1.png', N'toyota', N'landcruiser', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (883, CAST(0x000088F700000000 AS DateTime), NULL, N'Levin v1', N'http://cdn.carvalet.com/img/veh/toyota_levin_1.png', N'toyota', N'levin', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (884, CAST(0x0000918700000000 AS DateTime), CAST(0x0000918700000000 AS DateTime), N'Liteace v1', N'http://cdn.carvalet.com/img/veh/toyota_liteace_1.png', N'toyota', N'liteace', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (885, CAST(0x0000654C00000000 AS DateTime), NULL, N'Lucida v1', N'http://cdn.carvalet.com/img/veh/toyota_lucida_1.png', N'toyota', N'lucida', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (886, CAST(0x000070B600000000 AS DateTime), CAST(0x0000722300000000 AS DateTime), N'Mr2 v1', N'http://cdn.carvalet.com/img/veh/toyota_mr2_1.png', N'toyota', N'mr2', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (887, CAST(0x0000834200000000 AS DateTime), CAST(0x0000878A00000000 AS DateTime), N'Mr-S v1', N'http://cdn.carvalet.com/img/veh/toyota_mr-s_1.png', N'toyota', N'mr-s', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (888, CAST(0x00006F4900000000 AS DateTime), NULL, N'Noah v1', N'http://cdn.carvalet.com/img/veh/toyota_noah_1.png', N'toyota', N'noah', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (889, CAST(0x00006B0100000000 AS DateTime), NULL, N'Paseo v1', N'http://cdn.carvalet.com/img/veh/toyota_paseo_1.png', N'toyota', N'paseo', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (890, CAST(0x000092F400000000 AS DateTime), CAST(0x000098A900000000 AS DateTime), N'Picnic v1', N'http://cdn.carvalet.com/img/veh/toyota_picnic_1.png', N'toyota', N'picnic', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (891, CAST(0x0000861D00000000 AS DateTime), CAST(0x00008BD200000000 AS DateTime), N'Prado v1', N'http://cdn.carvalet.com/img/veh/toyota_prado_1.png', N'toyota', N'prado', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (892, CAST(0x00007C2000000000 AS DateTime), CAST(0x0000806800000000 AS DateTime), N'Previa v1', N'http://cdn.carvalet.com/img/veh/toyota_previa_1.png', N'toyota', N'previa', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (893, CAST(0x0000834200000000 AS DateTime), NULL, N'Prius v1', N'http://cdn.carvalet.com/img/veh/toyota_prius_1.png', N'toyota', N'prius', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (894, CAST(0x00007EFB00000000 AS DateTime), CAST(0x0000806800000000 AS DateTime), N'Rav 4 v1', N'http://cdn.carvalet.com/img/veh/toyota_rav_4_1.png', N'toyota', N'rav_4', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (895, CAST(0x00007C2000000000 AS DateTime), NULL, N'Rav4 v1', N'http://cdn.carvalet.com/img/veh/toyota_rav4_1.png', N'toyota', N'rav4', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (896, CAST(0x000081D500000000 AS DateTime), NULL, N'Soarer v1', N'http://cdn.carvalet.com/img/veh/toyota_soarer_1.png', N'toyota', N'soarer', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (897, CAST(0x00008EAC00000000 AS DateTime), CAST(0x0000918700000000 AS DateTime), N'Starlet v1', N'http://cdn.carvalet.com/img/veh/toyota_starlet_1.png', N'toyota', N'starlet', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (898, CAST(0x00007C2000000000 AS DateTime), NULL, N'Starlet Glanza V v1', N'http://cdn.carvalet.com/img/veh/toyota_starlet_glanza_v_1.png', N'toyota', N'starlet_glanza_v', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (899, CAST(0x0000861D00000000 AS DateTime), NULL, N'Supra v1', N'http://cdn.carvalet.com/img/veh/toyota_supra_1.png', N'toyota', N'supra', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (900, CAST(0x0000739100000000 AS DateTime), CAST(0x0000739100000000 AS DateTime), N'Surf v1', N'http://cdn.carvalet.com/img/veh/toyota_surf_1.png', N'toyota', N'surf', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (901, CAST(0x000098A900000000 AS DateTime), CAST(0x00009A1600000000 AS DateTime), N'Townace v1', N'http://cdn.carvalet.com/img/veh/toyota_townace_1.png', N'toyota', N'townace', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (902, CAST(0x000084B000000000 AS DateTime), NULL, N'Urbancruiser v1', N'http://cdn.carvalet.com/img/veh/toyota_urbancruiser_1.png', N'toyota', N'urbancruiser', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (903, CAST(0x00008EAC00000000 AS DateTime), NULL, N'Verso v1', N'http://cdn.carvalet.com/img/veh/toyota_verso_1.png', N'toyota', N'verso', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (904, CAST(0x0000682700000000 AS DateTime), NULL, N'Verso-S v1', N'http://cdn.carvalet.com/img/veh/toyota_verso-s_1.png', N'toyota', N'verso-s', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (905, CAST(0x0000654C00000000 AS DateTime), CAST(0x000066B900000000 AS DateTime), N'Yaris v1', N'http://cdn.carvalet.com/img/veh/toyota_yaris_1.png', N'toyota', N'yaris', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (906, CAST(0x0000794600000000 AS DateTime), NULL, N'Yaris Verso v1', N'http://cdn.carvalet.com/img/veh/toyota_yaris_verso_1.png', N'toyota', N'yaris_verso', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (907, CAST(0x00007EFB00000000 AS DateTime), NULL, N'P601 v1', N'http://cdn.carvalet.com/img/veh/trabant_p601_1.png', N'trabant', N'p601', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (908, CAST(0x00008EAC00000000 AS DateTime), CAST(0x0000901A00000000 AS DateTime), N'1500 v1', N'http://cdn.carvalet.com/img/veh/triumph_1500_1.png', N'triumph', N'1500', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (909, CAST(0x0000654C00000000 AS DateTime), NULL, N'Dolomite v1', N'http://cdn.carvalet.com/img/veh/triumph_dolomite_1.png', N'triumph', N'dolomite', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (910, CAST(0x00006B0100000000 AS DateTime), NULL, N'Herald v1', N'http://cdn.carvalet.com/img/veh/triumph_herald_1.png', N'triumph', N'herald', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (911, CAST(0x0000806800000000 AS DateTime), CAST(0x0000861D00000000 AS DateTime), N'Spitfire v1', N'http://cdn.carvalet.com/img/veh/triumph_spitfire_1.png', N'triumph', N'spitfire', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (912, CAST(0x000084B000000000 AS DateTime), NULL, N'Stag v1', N'http://cdn.carvalet.com/img/veh/triumph_stag_1.png', N'triumph', N'stag', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (913, CAST(0x00006B0100000000 AS DateTime), NULL, N'Tr2 v1', N'http://cdn.carvalet.com/img/veh/triumph_tr2_1.png', N'triumph', N'tr2', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (914, CAST(0x00007D8D00000000 AS DateTime), NULL, N'Tr4 v1', N'http://cdn.carvalet.com/img/veh/triumph_tr4_1.png', N'triumph', N'tr4', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (915, CAST(0x000074FE00000000 AS DateTime), NULL, N'Tr6 v1', N'http://cdn.carvalet.com/img/veh/triumph_tr6_1.png', N'triumph', N'tr6', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (916, CAST(0x00007AB300000000 AS DateTime), CAST(0x00007C2000000000 AS DateTime), N'Tr7 v1', N'http://cdn.carvalet.com/img/veh/triumph_tr7_1.png', N'triumph', N'tr7', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (917, CAST(0x000095CF00000000 AS DateTime), NULL, N'350I v1', N'http://cdn.carvalet.com/img/veh/tvr_350i_1.png', N'tvr', N'350i', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (918, CAST(0x00006F4900000000 AS DateTime), NULL, N'400 v1', N'http://cdn.carvalet.com/img/veh/tvr_400_1.png', N'tvr', N'400', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (919, CAST(0x0000766B00000000 AS DateTime), CAST(0x0000794600000000 AS DateTime), N'Cerbera v1', N'http://cdn.carvalet.com/img/veh/tvr_cerbera_1.png', N'tvr', N'cerbera', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (920, CAST(0x00006F4900000000 AS DateTime), NULL, N'Chimaera v1', N'http://cdn.carvalet.com/img/veh/tvr_chimaera_1.png', N'tvr', N'chimaera', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (921, CAST(0x0000918700000000 AS DateTime), CAST(0x0000973C00000000 AS DateTime), N'Griffith v1', N'http://cdn.carvalet.com/img/veh/tvr_griffith_1.png', N'tvr', N'griffith', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (922, CAST(0x000088F700000000 AS DateTime), CAST(0x00008BD200000000 AS DateTime), N'Sagaris v1', N'http://cdn.carvalet.com/img/veh/tvr_sagaris_1.png', N'tvr', N'sagaris', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (923, CAST(0x000063DF00000000 AS DateTime), CAST(0x000063DF00000000 AS DateTime), N'T350 v1', N'http://cdn.carvalet.com/img/veh/tvr_t350_1.png', N'tvr', N't350', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (924, CAST(0x0000918700000000 AS DateTime), NULL, N'Tamora v1', N'http://cdn.carvalet.com/img/veh/tvr_tamora_1.png', N'tvr', N'tamora', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (925, CAST(0x00008A6500000000 AS DateTime), CAST(0x00008A6500000000 AS DateTime), N'Tasmin v1', N'http://cdn.carvalet.com/img/veh/tvr_tasmin_1.png', N'tvr', N'tasmin', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (926, CAST(0x00006C6E00000000 AS DateTime), NULL, N'Tuscan v1', N'http://cdn.carvalet.com/img/veh/tvr_tuscan_1.png', N'tvr', N'tuscan', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (927, CAST(0x0000973C00000000 AS DateTime), CAST(0x00009A1600000000 AS DateTime), N'Gtr v1', N'http://cdn.carvalet.com/img/veh/ultima_gtr_1.png', N'ultima', N'gtr', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (928, CAST(0x0000806800000000 AS DateTime), CAST(0x0000806800000000 AS DateTime), N'Agila v1', N'http://cdn.carvalet.com/img/veh/vauxhall_agila_1.png', N'vauxhall', N'agila', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (929, CAST(0x00006F4900000000 AS DateTime), CAST(0x00006F4900000000 AS DateTime), N'Ampera v1', N'http://cdn.carvalet.com/img/veh/vauxhall_ampera_1.png', N'vauxhall', N'ampera', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (930, CAST(0x000092F400000000 AS DateTime), NULL, N'Antara v1', N'http://cdn.carvalet.com/img/veh/vauxhall_antara_1.png', N'vauxhall', N'antara', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (931, CAST(0x0000682700000000 AS DateTime), NULL, N'Astra v1', N'http://cdn.carvalet.com/img/veh/vauxhall_astra_1.png', N'vauxhall', N'astra', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (932, CAST(0x00008BD200000000 AS DateTime), NULL, N'Astra Gtc v1', N'http://cdn.carvalet.com/img/veh/vauxhall_astra_gtc_1.png', N'vauxhall', N'astra_gtc', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (933, CAST(0x0000806800000000 AS DateTime), CAST(0x000081D500000000 AS DateTime), N'Calibra v1', N'http://cdn.carvalet.com/img/veh/vauxhall_calibra_1.png', N'vauxhall', N'calibra', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (934, CAST(0x000063DF00000000 AS DateTime), NULL, N'Carlton v1', N'http://cdn.carvalet.com/img/veh/vauxhall_carlton_1.png', N'vauxhall', N'carlton', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (935, CAST(0x00007D8D00000000 AS DateTime), NULL, N'Cavalier v1', N'http://cdn.carvalet.com/img/veh/vauxhall_cavalier_1.png', N'vauxhall', N'cavalier', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (936, CAST(0x000074FE00000000 AS DateTime), CAST(0x00007AB300000000 AS DateTime), N'Combo Tour v1', N'http://cdn.carvalet.com/img/veh/vauxhall_combo_tour_1.png', N'vauxhall', N'combo_tour', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (937, CAST(0x00008EAC00000000 AS DateTime), NULL, N'Corsa v1', N'http://cdn.carvalet.com/img/veh/vauxhall_corsa_1.png', N'vauxhall', N'corsa', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (938, CAST(0x000081D500000000 AS DateTime), CAST(0x000084B000000000 AS DateTime), N'Frontera v1', N'http://cdn.carvalet.com/img/veh/vauxhall_frontera_1.png', N'vauxhall', N'frontera', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (939, CAST(0x000066B900000000 AS DateTime), CAST(0x000066B900000000 AS DateTime), N'Insignia v1', N'http://cdn.carvalet.com/img/veh/vauxhall_insignia_1.png', N'vauxhall', N'insignia', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (940, CAST(0x00006DDC00000000 AS DateTime), CAST(0x0000739100000000 AS DateTime), N'Meriva v1', N'http://cdn.carvalet.com/img/veh/vauxhall_meriva_1.png', N'vauxhall', N'meriva', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (941, CAST(0x0000973C00000000 AS DateTime), CAST(0x000098A900000000 AS DateTime), N'Monaro v1', N'http://cdn.carvalet.com/img/veh/vauxhall_monaro_1.png', N'vauxhall', N'monaro', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (942, CAST(0x00008A6500000000 AS DateTime), CAST(0x00008D3F00000000 AS DateTime), N'Monterey v1', N'http://cdn.carvalet.com/img/veh/vauxhall_monterey_1.png', N'vauxhall', N'monterey', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (943, CAST(0x0000806800000000 AS DateTime), CAST(0x000081D500000000 AS DateTime), N'Nova v1', N'http://cdn.carvalet.com/img/veh/vauxhall_nova_1.png', N'vauxhall', N'nova', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (944, CAST(0x0000946100000000 AS DateTime), NULL, N'Omega v1', N'http://cdn.carvalet.com/img/veh/vauxhall_omega_1.png', N'vauxhall', N'omega', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (945, CAST(0x0000739100000000 AS DateTime), CAST(0x0000794600000000 AS DateTime), N'Senator v1', N'http://cdn.carvalet.com/img/veh/vauxhall_senator_1.png', N'vauxhall', N'senator', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (946, CAST(0x0000794600000000 AS DateTime), NULL, N'Signum v1', N'http://cdn.carvalet.com/img/veh/vauxhall_signum_1.png', N'vauxhall', N'signum', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (947, CAST(0x000063DF00000000 AS DateTime), CAST(0x0000654C00000000 AS DateTime), N'Sintra v1', N'http://cdn.carvalet.com/img/veh/vauxhall_sintra_1.png', N'vauxhall', N'sintra', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (948, CAST(0x00007EFB00000000 AS DateTime), NULL, N'Tigra v1', N'http://cdn.carvalet.com/img/veh/vauxhall_tigra_1.png', N'vauxhall', N'tigra', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (949, CAST(0x00007EFB00000000 AS DateTime), CAST(0x0000806800000000 AS DateTime), N'Vectra v1', N'http://cdn.carvalet.com/img/veh/vauxhall_vectra_1.png', N'vauxhall', N'vectra', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (950, CAST(0x000095CF00000000 AS DateTime), CAST(0x00009A1600000000 AS DateTime), N'Victor v1', N'http://cdn.carvalet.com/img/veh/vauxhall_victor_1.png', N'vauxhall', N'victor', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (951, CAST(0x000081D500000000 AS DateTime), CAST(0x000084B000000000 AS DateTime), N'Viva v1', N'http://cdn.carvalet.com/img/veh/vauxhall_viva_1.png', N'vauxhall', N'viva', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (952, CAST(0x000066B900000000 AS DateTime), NULL, N'Vivaro v1', N'http://cdn.carvalet.com/img/veh/vauxhall_vivaro_1.png', N'vauxhall', N'vivaro', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (953, CAST(0x0000766B00000000 AS DateTime), NULL, N'Vx220 v1', N'http://cdn.carvalet.com/img/veh/vauxhall_vx220_1.png', N'vauxhall', N'vx220', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (954, CAST(0x0000834200000000 AS DateTime), NULL, N'Vxr8 v1', N'http://cdn.carvalet.com/img/veh/vauxhall_vxr8_1.png', N'vauxhall', N'vxr8', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (955, CAST(0x0000973C00000000 AS DateTime), CAST(0x000098A900000000 AS DateTime), N'Zafira v1', N'http://cdn.carvalet.com/img/veh/vauxhall_zafira_1.png', N'vauxhall', N'zafira', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (956, CAST(0x000095CF00000000 AS DateTime), CAST(0x0000973C00000000 AS DateTime), N'Amarok v1', N'http://cdn.carvalet.com/img/veh/volkswagen_amarok_1.png', N'volkswagen', N'amarok', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (957, CAST(0x00008BD200000000 AS DateTime), NULL, N'Beetle v1', N'http://cdn.carvalet.com/img/veh/volkswagen_beetle_1.png', N'volkswagen', N'beetle', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (958, CAST(0x0000739100000000 AS DateTime), NULL, N'Bora v1', N'http://cdn.carvalet.com/img/veh/volkswagen_bora_1.png', N'volkswagen', N'bora', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (959, CAST(0x00008D3F00000000 AS DateTime), NULL, N'Caddy Life v1', N'http://cdn.carvalet.com/img/veh/volkswagen_caddy_life_1.png', N'volkswagen', N'caddy_life', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (960, CAST(0x00006C6E00000000 AS DateTime), NULL, N'Caddy Maxi C20 v1', N'http://cdn.carvalet.com/img/veh/volkswagen_caddy_maxi_c20_1.png', N'volkswagen', N'caddy_maxi_c20', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (961, CAST(0x000084B000000000 AS DateTime), CAST(0x00008A6500000000 AS DateTime), N'Caddy Maxi Life v1', N'http://cdn.carvalet.com/img/veh/volkswagen_caddy_maxi_life_1.png', N'volkswagen', N'caddy_maxi_life', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (962, CAST(0x000092F400000000 AS DateTime), CAST(0x000095CF00000000 AS DateTime), N'California v1', N'http://cdn.carvalet.com/img/veh/volkswagen_california_1.png', N'volkswagen', N'california', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (963, CAST(0x0000682700000000 AS DateTime), CAST(0x00006C6E00000000 AS DateTime), N'Caravelle v1', N'http://cdn.carvalet.com/img/veh/volkswagen_caravelle_1.png', N'volkswagen', N'caravelle', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (964, CAST(0x0000946100000000 AS DateTime), NULL, N'Corrado v1', N'http://cdn.carvalet.com/img/veh/volkswagen_corrado_1.png', N'volkswagen', N'corrado', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (965, CAST(0x0000973C00000000 AS DateTime), CAST(0x00009CF100000000 AS DateTime), N'Eos v1', N'http://cdn.carvalet.com/img/veh/volkswagen_eos_1.png', N'volkswagen', N'eos', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (966, CAST(0x0000918700000000 AS DateTime), NULL, N'Fox v1', N'http://cdn.carvalet.com/img/veh/volkswagen_fox_1.png', N'volkswagen', N'fox', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (967, CAST(0x0000973C00000000 AS DateTime), NULL, N'Golf v1', N'http://cdn.carvalet.com/img/veh/volkswagen_golf_1.png', N'volkswagen', N'golf', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (968, CAST(0x0000766B00000000 AS DateTime), NULL, N'Golf Plus v1', N'http://cdn.carvalet.com/img/veh/volkswagen_golf_plus_1.png', N'volkswagen', N'golf_plus', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (969, CAST(0x000081D500000000 AS DateTime), NULL, N'Jetta v1', N'http://cdn.carvalet.com/img/veh/volkswagen_jetta_1.png', N'volkswagen', N'jetta', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (970, CAST(0x00006B0100000000 AS DateTime), CAST(0x00006F4900000000 AS DateTime), N'K70 v1', N'http://cdn.carvalet.com/img/veh/volkswagen_k70_1.png', N'volkswagen', N'k70', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (971, CAST(0x00007D8D00000000 AS DateTime), CAST(0x0000806800000000 AS DateTime), N'Karmann v1', N'http://cdn.carvalet.com/img/veh/volkswagen_karmann_1.png', N'volkswagen', N'karmann', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (972, CAST(0x0000973C00000000 AS DateTime), CAST(0x00009CF100000000 AS DateTime), N'Lupo v1', N'http://cdn.carvalet.com/img/veh/volkswagen_lupo_1.png', N'volkswagen', N'lupo', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (973, CAST(0x000066B900000000 AS DateTime), NULL, N'Passat v1', N'http://cdn.carvalet.com/img/veh/volkswagen_passat_1.png', N'volkswagen', N'passat', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (974, CAST(0x000070B600000000 AS DateTime), NULL, N'Passat Cc v1', N'http://cdn.carvalet.com/img/veh/volkswagen_passat_cc_1.png', N'volkswagen', N'passat_cc', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (975, CAST(0x0000794600000000 AS DateTime), CAST(0x00007C2000000000 AS DateTime), N'Phaeton v1', N'http://cdn.carvalet.com/img/veh/volkswagen_phaeton_1.png', N'volkswagen', N'phaeton', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (976, CAST(0x000063DF00000000 AS DateTime), CAST(0x000066B900000000 AS DateTime), N'Polo v1', N'http://cdn.carvalet.com/img/veh/volkswagen_polo_1.png', N'volkswagen', N'polo', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (977, CAST(0x0000901A00000000 AS DateTime), NULL, N'Scirocco v1', N'http://cdn.carvalet.com/img/veh/volkswagen_scirocco_1.png', N'volkswagen', N'scirocco', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (978, CAST(0x0000739100000000 AS DateTime), CAST(0x0000794600000000 AS DateTime), N'Sharan v1', N'http://cdn.carvalet.com/img/veh/volkswagen_sharan_1.png', N'volkswagen', N'sharan', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (979, CAST(0x00006B0100000000 AS DateTime), NULL, N'Tiguan v1', N'http://cdn.carvalet.com/img/veh/volkswagen_tiguan_1.png', N'volkswagen', N'tiguan', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (980, CAST(0x00006C6E00000000 AS DateTime), NULL, N'Touareg v1', N'http://cdn.carvalet.com/img/veh/volkswagen_touareg_1.png', N'volkswagen', N'touareg', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (981, CAST(0x000095CF00000000 AS DateTime), NULL, N'Touran v1', N'http://cdn.carvalet.com/img/veh/volkswagen_touran_1.png', N'volkswagen', N'touran', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (982, CAST(0x000074FE00000000 AS DateTime), NULL, N'Up v1', N'http://cdn.carvalet.com/img/veh/volkswagen_up_1.png', N'volkswagen', N'up', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (983, CAST(0x000098A900000000 AS DateTime), CAST(0x00009B8400000000 AS DateTime), N'Vento v1', N'http://cdn.carvalet.com/img/veh/volkswagen_vento_1.png', N'volkswagen', N'vento', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (984, CAST(0x00007D8D00000000 AS DateTime), CAST(0x000081D500000000 AS DateTime), N'240 v1', N'http://cdn.carvalet.com/img/veh/volvo_240_1.png', N'volvo', N'240', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (985, CAST(0x0000878A00000000 AS DateTime), CAST(0x0000878A00000000 AS DateTime), N'440 v1', N'http://cdn.carvalet.com/img/veh/volvo_440_1.png', N'volvo', N'440', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (986, CAST(0x00008BD200000000 AS DateTime), CAST(0x0000901A00000000 AS DateTime), N'460 v1', N'http://cdn.carvalet.com/img/veh/volvo_460_1.png', N'volvo', N'460', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (987, CAST(0x0000806800000000 AS DateTime), CAST(0x0000861D00000000 AS DateTime), N'480 v1', N'http://cdn.carvalet.com/img/veh/volvo_480_1.png', N'volvo', N'480', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (988, CAST(0x00007AB300000000 AS DateTime), CAST(0x00007D8D00000000 AS DateTime), N'740 v1', N'http://cdn.carvalet.com/img/veh/volvo_740_1.png', N'volvo', N'740', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (989, CAST(0x0000861D00000000 AS DateTime), NULL, N'850 v1', N'http://cdn.carvalet.com/img/veh/volvo_850_1.png', N'volvo', N'850', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (990, CAST(0x00006C6E00000000 AS DateTime), NULL, N'940 v1', N'http://cdn.carvalet.com/img/veh/volvo_940_1.png', N'volvo', N'940', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (991, CAST(0x00006F4900000000 AS DateTime), NULL, N'960 v1', N'http://cdn.carvalet.com/img/veh/volvo_960_1.png', N'volvo', N'960', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (992, CAST(0x000070B600000000 AS DateTime), CAST(0x0000722300000000 AS DateTime), N'C30 v1', N'http://cdn.carvalet.com/img/veh/volvo_c30_1.png', N'volvo', N'c30', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (993, CAST(0x0000901A00000000 AS DateTime), NULL, N'C70 v1', N'http://cdn.carvalet.com/img/veh/volvo_c70_1.png', N'volvo', N'c70', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (994, CAST(0x000074FE00000000 AS DateTime), NULL, N'Cross Country v1', N'http://cdn.carvalet.com/img/veh/volvo_cross_country_1.png', N'volvo', N'cross_country', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (995, CAST(0x00008BD200000000 AS DateTime), NULL, N'S40 v1', N'http://cdn.carvalet.com/img/veh/volvo_s40_1.png', N'volvo', N's40', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (996, CAST(0x000063DF00000000 AS DateTime), NULL, N'S60 v1', N'http://cdn.carvalet.com/img/veh/volvo_s60_1.png', N'volvo', N's60', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (997, CAST(0x000063DF00000000 AS DateTime), NULL, N'S70 v1', N'http://cdn.carvalet.com/img/veh/volvo_s70_1.png', N'volvo', N's70', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (998, CAST(0x00007C2000000000 AS DateTime), CAST(0x00007EFB00000000 AS DateTime), N'S80 v1', N'http://cdn.carvalet.com/img/veh/volvo_s80_1.png', N'volvo', N's80', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (999, CAST(0x00007D8D00000000 AS DateTime), NULL, N'V40 v1', N'http://cdn.carvalet.com/img/veh/volvo_v40_1.png', N'volvo', N'v40', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (1000, CAST(0x0000861D00000000 AS DateTime), CAST(0x0000878A00000000 AS DateTime), N'V50 v1', N'http://cdn.carvalet.com/img/veh/volvo_v50_1.png', N'volvo', N'v50', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (1001, CAST(0x00007AB300000000 AS DateTime), CAST(0x00007C2000000000 AS DateTime), N'V60 v1', N'http://cdn.carvalet.com/img/veh/volvo_v60_1.png', N'volvo', N'v60', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (1002, CAST(0x000063DF00000000 AS DateTime), CAST(0x0000699400000000 AS DateTime), N'V70 v1', N'http://cdn.carvalet.com/img/veh/volvo_v70_1.png', N'volvo', N'v70', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (1003, CAST(0x00007AB300000000 AS DateTime), CAST(0x00007AB300000000 AS DateTime), N'V90 v1', N'http://cdn.carvalet.com/img/veh/volvo_v90_1.png', N'volvo', N'v90', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (1004, CAST(0x00006F4900000000 AS DateTime), CAST(0x0000739100000000 AS DateTime), N'Xc60 v1', N'http://cdn.carvalet.com/img/veh/volvo_xc60_1.png', N'volvo', N'xc60', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (1005, CAST(0x0000861D00000000 AS DateTime), CAST(0x00008A6500000000 AS DateTime), N'Xc70 v1', N'http://cdn.carvalet.com/img/veh/volvo_xc70_1.png', N'volvo', N'xc70', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (1006, CAST(0x0000722300000000 AS DateTime), NULL, N'Xc90 v1', N'http://cdn.carvalet.com/img/veh/volvo_xc90_1.png', N'volvo', N'xc90', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (1007, CAST(0x000066B900000000 AS DateTime), NULL, N'2000 v1', N'http://cdn.carvalet.com/img/veh/westfield_2000_1.png', N'westfield', N'2000', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (1008, CAST(0x0000861D00000000 AS DateTime), NULL, N'Megabusa v1', N'http://cdn.carvalet.com/img/veh/westfield_megabusa_1.png', N'westfield', N'megabusa', N'MDN')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (1009, CAST(0x000063DF00000000 AS DateTime), CAST(0x0000682700000000 AS DateTime), N'Sei v1', N'http://cdn.carvalet.com/img/veh/westfield_sei_1.png', N'westfield', N'sei', N'CLASS')
GO
INSERT [dbo].[Vehicles] ([VehicleId], [ProducedFromUtc], [ProducedToUtc], [Name], [ImageUrl], [Model_MakeCode], [Model_ModelCode], [VehicleType_TypeCode]) VALUES (1010, CAST(0x0000946100000000 AS DateTime), NULL, N'16/60 v1', N'http://cdn.carvalet.com/img/veh/wolseley_16]]60_1.png', N'wolseley', N'16]]60', N'MDN')
GO
SET IDENTITY_INSERT [dbo].[Vehicles] OFF
GO
