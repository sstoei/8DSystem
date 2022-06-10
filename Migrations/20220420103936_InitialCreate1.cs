using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _8DSystem.Migrations
{
    public partial class InitialCreate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RefCauseSource",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefCauseSource", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RefFunction",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefFunction", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RefPCAStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefPCAStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RefStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Step = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Behavior = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkFlow",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RefStatusId = table.Column<int>(nullable: false),
                    ActionId = table.Column<string>(nullable: true),
                    ActionEmail = table.Column<string>(nullable: true),
                    ApproveId = table.Column<int>(nullable: false),
                    CancelId = table.Column<int>(nullable: false),
                    PreviousId = table.Column<int>(nullable: false),
                    RefStatusId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkFlow", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkFlow_RefStatus_RefStatusId1",
                        column: x => x.RefStatusId1,
                        principalTable: "RefStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReportHeader",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DateOpened = table.Column<DateTime>(nullable: true),
                    DateTargetedClosure = table.Column<DateTime>(nullable: true),
                    DateClosed = table.Column<DateTime>(nullable: true),
                    DateClosureD0 = table.Column<DateTime>(nullable: true),
                    DateClosureD1 = table.Column<DateTime>(nullable: true),
                    DateClosureD2 = table.Column<DateTime>(nullable: true),
                    DateClosureD3 = table.Column<DateTime>(nullable: true),
                    DateClosureD4 = table.Column<DateTime>(nullable: true),
                    DateClosureD5 = table.Column<DateTime>(nullable: true),
                    DateClosureD6 = table.Column<DateTime>(nullable: true),
                    DateClosureD7 = table.Column<DateTime>(nullable: true),
                    DateClosureD8 = table.Column<DateTime>(nullable: true),
                    DateEffectivenessCheck = table.Column<DateTime>(nullable: true),
                    DateCreate = table.Column<DateTime>(nullable: true),
                    CreateBy = table.Column<string>(maxLength: 7, nullable: true),
                    NcrNo = table.Column<string>(nullable: true),
                    Code = table.Column<string>(maxLength: 13, nullable: false),
                    WorkFlowId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportHeader", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReportHeader_WorkFlow_WorkFlowId",
                        column: x => x.WorkFlowId,
                        principalTable: "WorkFlow",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "D0",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    D0_Comment = table.Column<string>(nullable: true),
                    D0_PartNumber = table.Column<string>(maxLength: 100, nullable: true),
                    D0_PartDescription = table.Column<string>(nullable: true),
                    D0_PONum = table.Column<string>(maxLength: 100, nullable: true),
                    D0_POItem = table.Column<string>(nullable: true),
                    D0_CustomerContact = table.Column<string>(nullable: true),
                    D0_WitnessedBy = table.Column<string>(nullable: true),
                    D0_AffectedCustomerProduct = table.Column<string>(nullable: true),
                    D0_DeliveryAffected = table.Column<bool>(nullable: true),
                    D0_SuspectRootCauseIdentified = table.Column<bool>(nullable: true),
                    D0_RootCauseVerified = table.Column<bool>(nullable: true),
                    D0_EmergencyRespondAction = table.Column<bool>(nullable: true),
                    D0_RecurringProblem = table.Column<bool>(nullable: true),
                    ReportHeaderId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D0", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D0_ReportHeader_ReportHeaderId",
                        column: x => x.ReportHeaderId,
                        principalTable: "ReportHeader",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "D1",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RefFunctionId = table.Column<int>(nullable: false),
                    D1_EmployeeId = table.Column<string>(nullable: true),
                    D1_Email = table.Column<string>(nullable: true),
                    D1_PhoneNo = table.Column<string>(nullable: true),
                    D1_DateStart = table.Column<string>(nullable: true),
                    ReportHeaderId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D1", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D1_RefFunction_RefFunctionId",
                        column: x => x.RefFunctionId,
                        principalTable: "RefFunction",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_D1_ReportHeader_ReportHeaderId",
                        column: x => x.ReportHeaderId,
                        principalTable: "ReportHeader",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "D2",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    D2_DefineCustomerExperience = table.Column<string>(nullable: true),
                    D2_FailureMode = table.Column<string>(nullable: true),
                    D2_RequiredByTheSpecification = table.Column<string>(nullable: true),
                    D2_TheSpecificationDocument = table.Column<string>(nullable: true),
                    D2_ProblemSource = table.Column<string>(nullable: true),
                    D2_CustomerProblemTypeDefinition = table.Column<string>(nullable: true),
                    D2_NumberOfPartsProducedWithinProblemBoundary = table.Column<decimal>(nullable: true),
                    D2_NumberOfPartsAffected = table.Column<decimal>(nullable: true),
                    D2_PercenOfPartsAffected = table.Column<decimal>(nullable: true),
                    D2_RecurringProblem = table.Column<bool>(nullable: true),
                    D2_FailureModeInDPFMEA = table.Column<bool>(nullable: true),
                    D2_SupSupplier = table.Column<bool>(nullable: true),
                    D2_SupSupplierDetail = table.Column<string>(nullable: true),
                    D2_Organization = table.Column<bool>(nullable: true),
                    D2_OrganizationDetail = table.Column<string>(nullable: true),
                    D2_Customer = table.Column<bool>(nullable: true),
                    D2_CustomerDetail = table.Column<string>(nullable: true),
                    D2_Other1 = table.Column<bool>(nullable: true),
                    D2_Other1Detail = table.Column<string>(nullable: true),
                    D2_CustomerOfCustomer = table.Column<bool>(nullable: true),
                    D2_CustomerOfCustomerDetail = table.Column<string>(nullable: true),
                    D2_AircraftOperators = table.Column<bool>(nullable: true),
                    D2_AircraftOperatorsDetail = table.Column<string>(nullable: true),
                    D2_SpareParts = table.Column<bool>(nullable: false),
                    D2_SparePartsDetail = table.Column<string>(nullable: true),
                    D2_Other2 = table.Column<bool>(nullable: false),
                    D2_Other2Detail = table.Column<string>(nullable: true),
                    D2_ProblemPartEarliestKnownOccurrenceDate = table.Column<DateTime>(nullable: true),
                    D2_ProblemPartEarliestKnownAwarenessDate = table.Column<DateTime>(nullable: true),
                    D2_ProblemPartEarliestKnownShipmentDate = table.Column<DateTime>(nullable: true),
                    ReportHeaderId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D2", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D2_ReportHeader_ReportHeaderId",
                        column: x => x.ReportHeaderId,
                        principalTable: "ReportHeader",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "D3",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    D3_Action = table.Column<string>(nullable: true),
                    D3_TeamMember = table.Column<string>(maxLength: 7, nullable: true),
                    D3_DateStart = table.Column<DateTime>(nullable: true),
                    D3_DateFinish = table.Column<DateTime>(nullable: true),
                    D3_Metric = table.Column<decimal>(nullable: true),
                    D3_Eff = table.Column<decimal>(nullable: true),
                    D3_PartId = table.Column<string>(nullable: true),
                    ReportHeaderId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D3", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D3_ReportHeader_ReportHeaderId",
                        column: x => x.ReportHeaderId,
                        principalTable: "ReportHeader",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "D4",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    D4_HasEscapePointCausesBeenAddressed = table.Column<bool>(nullable: true),
                    D4_CanCausesExplainDifferences = table.Column<bool>(nullable: true),
                    D4_IdentifyCausesInProcessFMEA = table.Column<bool>(nullable: true),
                    D4_FishBone = table.Column<bool>(nullable: true),
                    D4_FiveWhy = table.Column<bool>(nullable: true),
                    ReportHeaderId = table.Column<Guid>(nullable: false),
                    RefCauseSourceId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D4", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D4_RefCauseSource_RefCauseSourceId",
                        column: x => x.RefCauseSourceId,
                        principalTable: "RefCauseSource",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_D4_ReportHeader_ReportHeaderId",
                        column: x => x.ReportHeaderId,
                        principalTable: "ReportHeader",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "D5",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReportHeaderId = table.Column<Guid>(nullable: false),
                    RefCauseSourceId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D5", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D5_RefCauseSource_RefCauseSourceId",
                        column: x => x.RefCauseSourceId,
                        principalTable: "RefCauseSource",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_D5_ReportHeader_ReportHeaderId",
                        column: x => x.ReportHeaderId,
                        principalTable: "ReportHeader",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "D6",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    D6_DateClosure = table.Column<DateTime>(nullable: true),
                    ReportHeaderId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D6", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D6_ReportHeader_ReportHeaderId",
                        column: x => x.ReportHeaderId,
                        principalTable: "ReportHeader",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "D7",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    D7_DateClosure = table.Column<DateTime>(nullable: true),
                    ReportHeaderId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D7", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D7_ReportHeader_ReportHeaderId",
                        column: x => x.ReportHeaderId,
                        principalTable: "ReportHeader",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "D8",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReportHeaderId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D8", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D8_ReportHeader_ReportHeaderId",
                        column: x => x.ReportHeaderId,
                        principalTable: "ReportHeader",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "D0_Attachment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(nullable: false),
                    Content = table.Column<byte[]>(nullable: false),
                    ContentName = table.Column<string>(nullable: false),
                    ContentMimeType = table.Column<string>(nullable: false),
                    D0Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D0_Attachment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D0_Attachment_D0_D0Id",
                        column: x => x.D0Id,
                        principalTable: "D0",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "D0_EmergencyRespondActio",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Action = table.Column<string>(nullable: true),
                    TeamMemberId = table.Column<string>(nullable: true),
                    DateStart = table.Column<DateTime>(nullable: true),
                    DateFinish = table.Column<DateTime>(nullable: true),
                    Metric = table.Column<string>(nullable: true),
                    Eff = table.Column<string>(nullable: true),
                    PartId = table.Column<string>(nullable: true),
                    D0Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D0_EmergencyRespondActio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D0_EmergencyRespondActio_D0_D0Id",
                        column: x => x.D0Id,
                        principalTable: "D0",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "D2_Attachment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(nullable: false),
                    Content = table.Column<byte[]>(nullable: false),
                    ContentName = table.Column<string>(nullable: false),
                    ContentMimeType = table.Column<string>(nullable: false),
                    D2Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D2_Attachment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D2_Attachment_D2_D2Id",
                        column: x => x.D2Id,
                        principalTable: "D2",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "D2_ImageConform",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(nullable: false),
                    Content = table.Column<byte[]>(nullable: false),
                    ContentName = table.Column<string>(nullable: false),
                    ContentMimeType = table.Column<string>(nullable: false),
                    D2Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D2_ImageConform", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D2_ImageConform_D2_D2Id",
                        column: x => x.D2Id,
                        principalTable: "D2",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "D2_ImageNoneConform",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(nullable: false),
                    Content = table.Column<byte[]>(nullable: false),
                    ContentName = table.Column<string>(nullable: false),
                    ContentMimeType = table.Column<string>(nullable: false),
                    D2Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D2_ImageNoneConform", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D2_ImageNoneConform_D2_D2Id",
                        column: x => x.D2Id,
                        principalTable: "D2",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "D3_Attachment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(nullable: false),
                    Content = table.Column<byte[]>(nullable: false),
                    ContentName = table.Column<string>(nullable: false),
                    ContentMimeType = table.Column<string>(nullable: false),
                    D3Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D3_Attachment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D3_Attachment_D3_D3Id",
                        column: x => x.D3Id,
                        principalTable: "D3",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "D4_Attachment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(nullable: false),
                    Content = table.Column<byte[]>(nullable: false),
                    ContentName = table.Column<string>(nullable: false),
                    ContentMimeType = table.Column<string>(nullable: false),
                    D4Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D4_Attachment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D4_Attachment_D4_D4Id",
                        column: x => x.D4Id,
                        principalTable: "D4",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "D4_FishBone",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Main = table.Column<string>(nullable: true),
                    Machine = table.Column<string>(nullable: true),
                    Manufacturing = table.Column<string>(nullable: true),
                    Measurement = table.Column<string>(nullable: true),
                    Material = table.Column<string>(nullable: true),
                    Environment = table.Column<string>(nullable: true),
                    D4Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D4_FishBone", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D4_FishBone_D4_D4Id",
                        column: x => x.D4Id,
                        principalTable: "D4",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "D4_FiveWhy",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DefineTheProblem = table.Column<string>(nullable: true),
                    WhyIsHappening = table.Column<string>(nullable: true),
                    HowItHappening1 = table.Column<string>(nullable: true),
                    WhyIsThat2 = table.Column<string>(nullable: true),
                    HowItHappening2 = table.Column<string>(nullable: true),
                    WhyIsThat3 = table.Column<string>(nullable: true),
                    HowItHappening3 = table.Column<string>(nullable: true),
                    WhyIsThat4 = table.Column<string>(nullable: true),
                    HowItHappening4 = table.Column<string>(nullable: true),
                    D4Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D4_FiveWhy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D4_FiveWhy_D4_D4Id",
                        column: x => x.D4Id,
                        principalTable: "D4",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "D5_Action",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CauseSourceId = table.Column<int>(nullable: true),
                    Detail = table.Column<string>(nullable: true),
                    Verify = table.Column<bool>(nullable: true),
                    Date = table.Column<DateTime>(nullable: true),
                    VerificationMethod = table.Column<string>(nullable: true),
                    D5Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D5_Action", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D5_Action_D5_D5Id",
                        column: x => x.D5Id,
                        principalTable: "D5",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "D5_Attachment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(nullable: false),
                    Content = table.Column<byte[]>(nullable: false),
                    ContentName = table.Column<string>(nullable: false),
                    ContentMimeType = table.Column<string>(nullable: false),
                    D5Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D5_Attachment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D5_Attachment_D5_D5Id",
                        column: x => x.D5Id,
                        principalTable: "D5",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "D6_Action",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Detail = table.Column<string>(nullable: true),
                    ImplementationPlan = table.Column<string>(nullable: true),
                    TeamMemberId = table.Column<string>(nullable: true),
                    CustomerConcurrence = table.Column<bool>(nullable: true),
                    ImplementActionDate = table.Column<DateTime>(nullable: true),
                    VerificationMethod = table.Column<string>(nullable: true),
                    RefPCAStatusId = table.Column<int>(nullable: true),
                    D6Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D6_Action", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D6_Action_D6_D6Id",
                        column: x => x.D6Id,
                        principalTable: "D6",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_D6_Action_RefPCAStatus_RefPCAStatusId",
                        column: x => x.RefPCAStatusId,
                        principalTable: "RefPCAStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "D6_Attachment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(nullable: false),
                    Content = table.Column<byte[]>(nullable: false),
                    ContentName = table.Column<string>(nullable: false),
                    ContentMimeType = table.Column<string>(nullable: false),
                    D6Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D6_Attachment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D6_Attachment_D6_D6Id",
                        column: x => x.D6Id,
                        principalTable: "D6",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "D7_A",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PreventiveAction = table.Column<string>(nullable: true),
                    PAImplementationPlan = table.Column<string>(nullable: true),
                    TeamMemberId = table.Column<string>(maxLength: 7, nullable: true),
                    TargetDate = table.Column<DateTime>(nullable: true),
                    ActualDate = table.Column<DateTime>(nullable: true),
                    RefPCAStatusId = table.Column<int>(nullable: true),
                    D7Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D7_A", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D7_A_D7_D7Id",
                        column: x => x.D7Id,
                        principalTable: "D7",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_D7_A_RefPCAStatus_RefPCAStatusId",
                        column: x => x.RefPCAStatusId,
                        principalTable: "RefPCAStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "D7_Attachment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(nullable: false),
                    Content = table.Column<byte[]>(nullable: false),
                    ContentName = table.Column<string>(nullable: false),
                    ContentMimeType = table.Column<string>(nullable: false),
                    D7Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D7_Attachment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D7_Attachment_D7_D7Id",
                        column: x => x.D7Id,
                        principalTable: "D7",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "D7_B",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Process = table.Column<string>(nullable: true),
                    Responsible = table.Column<string>(nullable: true),
                    PlanValidationDate = table.Column<DateTime>(nullable: true),
                    D7Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D7_B", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D7_B_D7_D7Id",
                        column: x => x.D7Id,
                        principalTable: "D7",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "D7_C",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NatureOfRevisionNo1 = table.Column<string>(nullable: true),
                    NatureOfRevisionNo2 = table.Column<string>(nullable: true),
                    NatureOfRevisionNo3 = table.Column<string>(nullable: true),
                    NatureOfRevisionNo4 = table.Column<string>(nullable: true),
                    NatureOfRevisionNo5 = table.Column<string>(nullable: true),
                    NatureOfRevisionNo6 = table.Column<string>(nullable: true),
                    NatureOfRevisionNo7 = table.Column<string>(nullable: true),
                    NatureOfRevisionNo8 = table.Column<string>(nullable: true),
                    NatureOfRevisionNo9 = table.Column<string>(nullable: true),
                    NatureOfRevisionNo10 = table.Column<string>(nullable: true),
                    NatureOfRevisionNo11 = table.Column<string>(nullable: true),
                    NatureOfRevisionNo12 = table.Column<string>(nullable: true),
                    NatureOfRevisionNo13 = table.Column<string>(nullable: true),
                    NatureOfRevisionNo14 = table.Column<string>(nullable: true),
                    NatureOfRevisionNo15 = table.Column<string>(nullable: true),
                    Resp1 = table.Column<string>(nullable: true),
                    Resp2 = table.Column<string>(nullable: true),
                    Resp3 = table.Column<string>(nullable: true),
                    Resp4 = table.Column<string>(nullable: true),
                    Resp5 = table.Column<string>(nullable: true),
                    Resp6 = table.Column<string>(nullable: true),
                    Resp7 = table.Column<string>(nullable: true),
                    Resp8 = table.Column<string>(nullable: true),
                    Resp9 = table.Column<string>(nullable: true),
                    Resp10 = table.Column<string>(nullable: true),
                    Resp11 = table.Column<string>(nullable: true),
                    Resp12 = table.Column<string>(nullable: true),
                    Resp13 = table.Column<string>(nullable: true),
                    Resp14 = table.Column<string>(nullable: true),
                    Resp15 = table.Column<string>(nullable: true),
                    PlanDate1 = table.Column<DateTime>(nullable: true),
                    PlanDate2 = table.Column<DateTime>(nullable: true),
                    PlanDate3 = table.Column<DateTime>(nullable: true),
                    PlanDate4 = table.Column<DateTime>(nullable: true),
                    PlanDate5 = table.Column<DateTime>(nullable: true),
                    PlanDate6 = table.Column<DateTime>(nullable: true),
                    PlanDate7 = table.Column<DateTime>(nullable: true),
                    PlanDate8 = table.Column<DateTime>(nullable: true),
                    PlanDate9 = table.Column<DateTime>(nullable: true),
                    PlanDate10 = table.Column<DateTime>(nullable: true),
                    PlanDate11 = table.Column<DateTime>(nullable: true),
                    PlanDate12 = table.Column<DateTime>(nullable: true),
                    PlanDate13 = table.Column<DateTime>(nullable: true),
                    PlanDate14 = table.Column<DateTime>(nullable: true),
                    PlanDate15 = table.Column<DateTime>(nullable: true),
                    ActualDate1 = table.Column<DateTime>(nullable: true),
                    ActualDate2 = table.Column<DateTime>(nullable: true),
                    ActualDate3 = table.Column<DateTime>(nullable: true),
                    ActualDate4 = table.Column<DateTime>(nullable: true),
                    ActualDate5 = table.Column<DateTime>(nullable: true),
                    ActualDate6 = table.Column<DateTime>(nullable: true),
                    ActualDate7 = table.Column<DateTime>(nullable: true),
                    ActualDate8 = table.Column<DateTime>(nullable: true),
                    ActualDate9 = table.Column<DateTime>(nullable: true),
                    ActualDate10 = table.Column<DateTime>(nullable: true),
                    ActualDate11 = table.Column<DateTime>(nullable: true),
                    ActualDate12 = table.Column<DateTime>(nullable: true),
                    ActualDate13 = table.Column<DateTime>(nullable: true),
                    ActualDate14 = table.Column<DateTime>(nullable: true),
                    ActualDate15 = table.Column<DateTime>(nullable: true),
                    D7Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D7_C", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D7_C_D7_D7Id",
                        column: x => x.D7Id,
                        principalTable: "D7",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "D8_A",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlanDate = table.Column<DateTime>(nullable: true),
                    ActualDate = table.Column<DateTime>(nullable: true),
                    D8Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D8_A", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D8_A_D8_D8Id",
                        column: x => x.D8Id,
                        principalTable: "D8",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "D8_Attachment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(nullable: false),
                    Content = table.Column<byte[]>(nullable: false),
                    ContentName = table.Column<string>(nullable: false),
                    ContentMimeType = table.Column<string>(nullable: false),
                    D8Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D8_Attachment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D8_Attachment_D8_D8Id",
                        column: x => x.D8Id,
                        principalTable: "D8",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "D8_B",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title1 = table.Column<string>(nullable: true),
                    Title2 = table.Column<string>(nullable: true),
                    Signature1 = table.Column<string>(nullable: true),
                    Signature2 = table.Column<string>(nullable: true),
                    Date1 = table.Column<DateTime>(nullable: true),
                    Date2 = table.Column<DateTime>(nullable: true),
                    D8Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D8_B", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D8_B_D8_D8Id",
                        column: x => x.D8Id,
                        principalTable: "D8",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "D8_C",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    When = table.Column<string>(nullable: true),
                    Where = table.Column<string>(nullable: true),
                    How = table.Column<string>(nullable: true),
                    D8Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D8_C", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D8_C_D8_D8Id",
                        column: x => x.D8Id,
                        principalTable: "D8",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_D0_ReportHeaderId",
                table: "D0",
                column: "ReportHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_D0_Attachment_D0Id",
                table: "D0_Attachment",
                column: "D0Id");

            migrationBuilder.CreateIndex(
                name: "IX_D0_EmergencyRespondActio_D0Id",
                table: "D0_EmergencyRespondActio",
                column: "D0Id");

            migrationBuilder.CreateIndex(
                name: "IX_D1_RefFunctionId",
                table: "D1",
                column: "RefFunctionId");

            migrationBuilder.CreateIndex(
                name: "IX_D1_ReportHeaderId",
                table: "D1",
                column: "ReportHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_D2_ReportHeaderId",
                table: "D2",
                column: "ReportHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_D2_Attachment_D2Id",
                table: "D2_Attachment",
                column: "D2Id");

            migrationBuilder.CreateIndex(
                name: "IX_D2_ImageConform_D2Id",
                table: "D2_ImageConform",
                column: "D2Id");

            migrationBuilder.CreateIndex(
                name: "IX_D2_ImageNoneConform_D2Id",
                table: "D2_ImageNoneConform",
                column: "D2Id");

            migrationBuilder.CreateIndex(
                name: "IX_D3_ReportHeaderId",
                table: "D3",
                column: "ReportHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_D3_Attachment_D3Id",
                table: "D3_Attachment",
                column: "D3Id");

            migrationBuilder.CreateIndex(
                name: "IX_D4_RefCauseSourceId",
                table: "D4",
                column: "RefCauseSourceId");

            migrationBuilder.CreateIndex(
                name: "IX_D4_ReportHeaderId",
                table: "D4",
                column: "ReportHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_D4_Attachment_D4Id",
                table: "D4_Attachment",
                column: "D4Id");

            migrationBuilder.CreateIndex(
                name: "IX_D4_FishBone_D4Id",
                table: "D4_FishBone",
                column: "D4Id");

            migrationBuilder.CreateIndex(
                name: "IX_D4_FiveWhy_D4Id",
                table: "D4_FiveWhy",
                column: "D4Id");

            migrationBuilder.CreateIndex(
                name: "IX_D5_RefCauseSourceId",
                table: "D5",
                column: "RefCauseSourceId");

            migrationBuilder.CreateIndex(
                name: "IX_D5_ReportHeaderId",
                table: "D5",
                column: "ReportHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_D5_Action_D5Id",
                table: "D5_Action",
                column: "D5Id");

            migrationBuilder.CreateIndex(
                name: "IX_D5_Attachment_D5Id",
                table: "D5_Attachment",
                column: "D5Id");

            migrationBuilder.CreateIndex(
                name: "IX_D6_ReportHeaderId",
                table: "D6",
                column: "ReportHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_D6_Action_D6Id",
                table: "D6_Action",
                column: "D6Id");

            migrationBuilder.CreateIndex(
                name: "IX_D6_Action_RefPCAStatusId",
                table: "D6_Action",
                column: "RefPCAStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_D6_Attachment_D6Id",
                table: "D6_Attachment",
                column: "D6Id");

            migrationBuilder.CreateIndex(
                name: "IX_D7_ReportHeaderId",
                table: "D7",
                column: "ReportHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_D7_A_D7Id",
                table: "D7_A",
                column: "D7Id");

            migrationBuilder.CreateIndex(
                name: "IX_D7_A_RefPCAStatusId",
                table: "D7_A",
                column: "RefPCAStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_D7_Attachment_D7Id",
                table: "D7_Attachment",
                column: "D7Id");

            migrationBuilder.CreateIndex(
                name: "IX_D7_B_D7Id",
                table: "D7_B",
                column: "D7Id");

            migrationBuilder.CreateIndex(
                name: "IX_D7_C_D7Id",
                table: "D7_C",
                column: "D7Id");

            migrationBuilder.CreateIndex(
                name: "IX_D8_ReportHeaderId",
                table: "D8",
                column: "ReportHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_D8_A_D8Id",
                table: "D8_A",
                column: "D8Id");

            migrationBuilder.CreateIndex(
                name: "IX_D8_Attachment_D8Id",
                table: "D8_Attachment",
                column: "D8Id");

            migrationBuilder.CreateIndex(
                name: "IX_D8_B_D8Id",
                table: "D8_B",
                column: "D8Id");

            migrationBuilder.CreateIndex(
                name: "IX_D8_C_D8Id",
                table: "D8_C",
                column: "D8Id");

            migrationBuilder.CreateIndex(
                name: "IX_ReportHeader_WorkFlowId",
                table: "ReportHeader",
                column: "WorkFlowId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkFlow_RefStatusId1",
                table: "WorkFlow",
                column: "RefStatusId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "D0_Attachment");

            migrationBuilder.DropTable(
                name: "D0_EmergencyRespondActio");

            migrationBuilder.DropTable(
                name: "D1");

            migrationBuilder.DropTable(
                name: "D2_Attachment");

            migrationBuilder.DropTable(
                name: "D2_ImageConform");

            migrationBuilder.DropTable(
                name: "D2_ImageNoneConform");

            migrationBuilder.DropTable(
                name: "D3_Attachment");

            migrationBuilder.DropTable(
                name: "D4_Attachment");

            migrationBuilder.DropTable(
                name: "D4_FishBone");

            migrationBuilder.DropTable(
                name: "D4_FiveWhy");

            migrationBuilder.DropTable(
                name: "D5_Action");

            migrationBuilder.DropTable(
                name: "D5_Attachment");

            migrationBuilder.DropTable(
                name: "D6_Action");

            migrationBuilder.DropTable(
                name: "D6_Attachment");

            migrationBuilder.DropTable(
                name: "D7_A");

            migrationBuilder.DropTable(
                name: "D7_Attachment");

            migrationBuilder.DropTable(
                name: "D7_B");

            migrationBuilder.DropTable(
                name: "D7_C");

            migrationBuilder.DropTable(
                name: "D8_A");

            migrationBuilder.DropTable(
                name: "D8_Attachment");

            migrationBuilder.DropTable(
                name: "D8_B");

            migrationBuilder.DropTable(
                name: "D8_C");

            migrationBuilder.DropTable(
                name: "D0");

            migrationBuilder.DropTable(
                name: "RefFunction");

            migrationBuilder.DropTable(
                name: "D2");

            migrationBuilder.DropTable(
                name: "D3");

            migrationBuilder.DropTable(
                name: "D4");

            migrationBuilder.DropTable(
                name: "D5");

            migrationBuilder.DropTable(
                name: "D6");

            migrationBuilder.DropTable(
                name: "RefPCAStatus");

            migrationBuilder.DropTable(
                name: "D7");

            migrationBuilder.DropTable(
                name: "D8");

            migrationBuilder.DropTable(
                name: "RefCauseSource");

            migrationBuilder.DropTable(
                name: "ReportHeader");

            migrationBuilder.DropTable(
                name: "WorkFlow");

            migrationBuilder.DropTable(
                name: "RefStatus");
        }
    }
}
