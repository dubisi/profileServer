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

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220831132447_azure')
BEGIN
    CREATE TABLE [Personal] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [LastName] nvarchar(max) NULL,
        [Email] nvarchar(max) NULL,
        CONSTRAINT [PK_Personal] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220831132447_azure')
BEGIN
    CREATE TABLE [About] (
        [Id] int NOT NULL IDENTITY,
        [AboutMe] nvarchar(max) NULL,
        [ImagePath] nvarchar(max) NULL,
        [Resume] nvarchar(max) NULL,
        [PersonalId] int NOT NULL,
        CONSTRAINT [PK_About] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_About_Personal_PersonalId] FOREIGN KEY ([PersonalId]) REFERENCES [Personal] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220831132447_azure')
BEGIN
    CREATE TABLE [Contact] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [Link] nvarchar(max) NULL,
        [PersonalID] int NOT NULL,
        CONSTRAINT [PK_Contact] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Contact_Personal_PersonalID] FOREIGN KEY ([PersonalID]) REFERENCES [Personal] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220831132447_azure')
BEGIN
    CREATE TABLE [Education] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [Title] nvarchar(max) NULL,
        [Description] nvarchar(max) NULL,
        [StartYear] nvarchar(max) NULL,
        [EndYear] nvarchar(max) NULL,
        [PersonalId] int NOT NULL,
        CONSTRAINT [PK_Education] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Education_Personal_PersonalId] FOREIGN KEY ([PersonalId]) REFERENCES [Personal] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220831132447_azure')
BEGIN
    CREATE TABLE [Experiences] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [Title] nvarchar(max) NULL,
        [Description] nvarchar(max) NULL,
        [StartYear] nvarchar(max) NULL,
        [EndYear] nvarchar(max) NULL,
        [PersonalId] int NOT NULL,
        CONSTRAINT [PK_Experiences] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Experiences_Personal_PersonalId] FOREIGN KEY ([PersonalId]) REFERENCES [Personal] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220831132447_azure')
BEGIN
    CREATE TABLE [Projects] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [Dev] nvarchar(max) NULL,
        [Languages] nvarchar(max) NULL,
        [Description] nvarchar(max) NULL,
        [Link] nvarchar(max) NULL,
        [ExternalLink] nvarchar(max) NULL,
        [PersonalId] int NOT NULL,
        CONSTRAINT [PK_Projects] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Projects_Personal_PersonalId] FOREIGN KEY ([PersonalId]) REFERENCES [Personal] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220831132447_azure')
BEGIN
    CREATE TABLE [Skills] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [SkillSet] nvarchar(max) NULL,
        [PersonalId] int NOT NULL,
        CONSTRAINT [PK_Skills] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Skills_Personal_PersonalId] FOREIGN KEY ([PersonalId]) REFERENCES [Personal] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220831132447_azure')
BEGIN
    CREATE INDEX [IX_About_PersonalId] ON [About] ([PersonalId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220831132447_azure')
BEGIN
    CREATE INDEX [IX_Contact_PersonalID] ON [Contact] ([PersonalID]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220831132447_azure')
BEGIN
    CREATE INDEX [IX_Education_PersonalId] ON [Education] ([PersonalId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220831132447_azure')
BEGIN
    CREATE INDEX [IX_Experiences_PersonalId] ON [Experiences] ([PersonalId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220831132447_azure')
BEGIN
    CREATE INDEX [IX_Projects_PersonalId] ON [Projects] ([PersonalId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220831132447_azure')
BEGIN
    CREATE INDEX [IX_Skills_PersonalId] ON [Skills] ([PersonalId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220831132447_azure')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220831132447_azure', N'6.0.8');
END;
GO

COMMIT;
GO

