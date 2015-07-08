/*==============================================================*/
/* Nom de SGBD :  Microsoft SQL Server 2008                     */
/* Date de création :  11/01/2015 15:13:59                      */
/*==============================================================*/
create database MINIPROJETBANQUE
go
use MINIPROJETBANQUE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('AGENTS')
            and   type = 'U')
   drop table AGENTS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CLIENTS')
            and   type = 'U')
   drop table CLIENTS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('COMPTES')
            and   type = 'U')
   drop table COMPTES
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DEMANDES')
            and   type = 'U')
   drop table DEMANDES
go

if exists (select 1
            from  sysobjects
           where  id = object_id('EFFECTUER')
            and   type = 'U')
   drop table EFFECTUER
go

if exists (select 1
            from  sysobjects
           where  id = object_id('FAIRE_DES_DEMANDE')
            and   type = 'U')
   drop table FAIRE_DES_DEMANDE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('OPERATIONS')
            and   type = 'U')
   drop table OPERATIONS
go

/*==============================================================*/
/* Table : AGENTS                                               */
/*==============================================================*/
create table AGENTS (
   CIN_AGENT            varchar(10)          not null,
   NOM_AGENT            varchar(50)          not null,
   PRENOM_AGENT         varchar(50)          not null,
   TELEPHONE_AGENT      varchar(50)          not null,
   ADRESSE_AGENT        varchar(100)         not null,
   MOTPASS_AGENT        varchar(100)         not null,
   constraint PK_AGENTS primary key   (CIN_AGENT)
)
go

/*==============================================================*/
/* Table : CLIENTS                                              */
/*==============================================================*/
create table CLIENTS (
   CIN_CLIENT           varchar(10)          not null,
   NOM_CLIENT           varchar(50)          not null,
   PRENOM_CLIENT        varchar(50)          not null,
   DATENAISSANCE_CLIENT date	             not null,
   TELEPHONE_CLIENT     varchar(50)          not null,
   EMAIL_CLIENT         varchar(50)          not null,
   ADRESSE_CLIENT       varchar(100)         not null,
   NATIONALITE_CLIENT   varchar(50)          not null,
   CIVILITE_CLIENT      varchar(50)          not null,
   constraint PK_CLIENTS primary key   (CIN_CLIENT)
)
go
/*==============================================================*/
/* Table : COMPTES                                              */
/*==============================================================*/
create table COMPTES (
   NUMERO_COMPTE        varchar(50)          not null,
   CIN_AGENT            varchar(10)          not null,
   CIN_CLIENT           varchar(10)          not null,
   SOLDE_COMPTE         float               not null,
   DATEOUVERTURE_COMPTE date	             not null,
   MOTPASS_COMPTE       varchar(10)          not null,
   ETAT_COMPTE          varchar(50)          not null,
   ACTIVE_COMPTE        bit                  not null,
   DATEFERMETURE_COMPTE date	             null,
   constraint PK_COMPTES primary key   (NUMERO_COMPTE),
   constraint FK_AGENTS foreign key(CIN_AGENT) references AGENTS(CIN_AGENT),
   constraint FK_CLIENTS foreign key(CIN_CLIENT) references CLIENTS(CIN_CLIENT)
)
go


/*==============================================================*/
/* Table : DEMANDES                                             */
/*==============================================================*/
create table DEMANDES (
   ID_DEMANDE           int       identity    primary key        not null,
   TYPE_DEMANDE         varchar(50)          not null,
   DATE_DEMANDE         date	             not null,
   ETAT_DEMANDE         bit                   null,
)
go

/*==============================================================*/
/* Table : FAIRE_DES_DEMANDE                                    */
/*==============================================================*/
create table FAIRE_DES_DEMANDE (
   CIN_AGENT            varchar(10)          not null,
   NUMERO_COMPTE        varchar(50)          not null,
   ID_DEMANDE           int                  not null,
   constraint PK_FAIRE_DES_DEMANDE primary key   (CIN_AGENT, NUMERO_COMPTE, ID_DEMANDE),
   constraint FK_AG foreign key(CIN_AGENT) references AGENTS(CIN_AGENT),
   constraint FK_COM foreign key(NUMERO_COMPTE) references COMPTES(NUMERO_COMPTE),
   constraint FK_DEM foreign key(ID_DEMANDE) references DEMANDES(ID_DEMANDE),

)
go

/*==============================================================*/
/* Table : OPERATIONS                                           */
/*==============================================================*/
create table OPERATIONS (
   ID_OPERATION         int        identity          not null,
   TYPE_OPERATION       varchar(50)          not null,
   DATE_OPERATION       date	             not null,
   HEURE_OPERATION      time	             not null,
   MONTANT_OPERATION    money                not null,
   CIN_AGENT            varchar(10)          null,
   constraint PK_OPERATIONS primary key   (ID_OPERATION),
   constraint FK_AG1 foreign key(CIN_AGENT) references AGENTS(CIN_AGENT)
   
   
)
go

/*==============================================================*/
/* Table : EFFECTUER                                            */
/*==============================================================*/
create table EFFECTUER (
   NUMERO_COMPTE        varchar(50)          not null,
   ID_OPERATION         int                  not null,
   ETAT                 varchar(30)          null,
   constraint PK_EFFECTUER primary key   (NUMERO_COMPTE, ID_OPERATION),
   constraint FK_COME foreign key(NUMERO_COMPTE) references COMPTES(NUMERO_COMPTE),
   constraint FK_OPE foreign key(ID_OPERATION) references OPERATIONS(ID_OPERATION)
)
go


