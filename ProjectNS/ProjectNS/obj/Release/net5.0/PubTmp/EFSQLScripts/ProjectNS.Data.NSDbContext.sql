IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220424170324_Intial')
BEGIN
    CREATE TABLE [FDAClassification] (
        [FDAClassificationId] int NOT NULL IDENTITY,
        [FdaClassificationName] nvarchar(30) NULL,
        [Description] nvarchar(255) NULL,
        CONSTRAINT [PK_FDAClassification] PRIMARY KEY ([FDAClassificationId])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220424170324_Intial')
BEGIN
    CREATE TABLE [RecallInfo] (
        [RecallInfoId] int NOT NULL IDENTITY,
        [RecallId] int NOT NULL,
        [RecallName] nvarchar(30) NULL,
        [RecallType] nvarchar(30) NULL,
        [RecallDate] nvarchar(max) NULL,
        [ZNumber] int NOT NULL,
        [FDAClassification] nvarchar(30) NULL,
        [RecallCategories] nvarchar(30) NULL,
        [RecallStatus] nvarchar(30) NULL,
        [MarkAsUrgent] bit NOT NULL,
        [CustomizeedContent] bit NOT NULL,
        [SupplierVoluntaryRegulatoryMandate] nvarchar(30) NULL,
        [SupportingMaterial] nvarchar(255) NULL,
        [Description] nvarchar(max) NULL,
        CONSTRAINT [PK_RecallInfo] PRIMARY KEY ([RecallInfoId])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220424170324_Intial')
BEGIN
    CREATE TABLE [RecallType] (
        [RecallTypeId] int NOT NULL IDENTITY,
        [RecallTypeName] nvarchar(30) NULL,
        [Description] nvarchar(255) NULL,
        CONSTRAINT [PK_RecallType] PRIMARY KEY ([RecallTypeId])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220424170324_Intial')
BEGIN
    CREATE TABLE [RecallCategories] (
        [RecallCategoriesId] int NOT NULL IDENTITY,
        [RecallCategoriesName] nvarchar(30) NULL,
        [Description] nvarchar(255) NULL,
        [RecallInfoId] int NULL,
        CONSTRAINT [PK_RecallCategories] PRIMARY KEY ([RecallCategoriesId]),
        CONSTRAINT [FK_RecallCategories_RecallInfo_RecallInfoId] FOREIGN KEY ([RecallInfoId]) REFERENCES [RecallInfo] ([RecallInfoId]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220424170324_Intial')
BEGIN
    CREATE INDEX [IX_RecallCategories_RecallInfoId] ON [RecallCategories] ([RecallInfoId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220424170324_Intial')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220424170324_Intial', N'5.0.15');
END;
GO

COMMIT;
GO

