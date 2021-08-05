using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace FirstApp.Models
{
    public partial class newmed2_dockerContext : DbContext
    {
        public newmed2_dockerContext()
        {
        }

        public newmed2_dockerContext(DbContextOptions<newmed2_dockerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Actionrequest> Actionrequests { get; set; }
        public virtual DbSet<Additionalvalue> Additionalvalues { get; set; }
        public virtual DbSet<Algorithm> Algorithms { get; set; }
        public virtual DbSet<Answer> Answers { get; set; }
        public virtual DbSet<Answerable> Answerables { get; set; }
        public virtual DbSet<AnswerableorgunitTable> AnswerableorgunitTables { get; set; }
        public virtual DbSet<Answerabletype> Answerabletypes { get; set; }
        public virtual DbSet<Answertemplate> Answertemplates { get; set; }
        public virtual DbSet<Appcontstant> Appcontstants { get; set; }
        public virtual DbSet<Artefact> Artefacts { get; set; }
        public virtual DbSet<Artefacttype> Artefacttypes { get; set; }
        public virtual DbSet<Authenticity> Authenticities { get; set; }
        public virtual DbSet<Authenticitytype> Authenticitytypes { get; set; }
        public virtual DbSet<Block> Blocks { get; set; }
        public virtual DbSet<Calcvalue> Calcvalues { get; set; }
        public virtual DbSet<ChildorgunitTable> ChildorgunitTables { get; set; }
        public virtual DbSet<Commentpattern> Commentpatterns { get; set; }
        public virtual DbSet<Conclusion> Conclusions { get; set; }
        public virtual DbSet<Conversation> Conversations { get; set; }
        public virtual DbSet<Device> Devices { get; set; }
        public virtual DbSet<DeviceArtefact> DeviceArtefacts { get; set; }
        public virtual DbSet<Devicestatus> Devicestatuses { get; set; }
        public virtual DbSet<Devicetype> Devicetypes { get; set; }
        public virtual DbSet<Doctoractivitystatus> Doctoractivitystatuses { get; set; }
        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<DocumentArtefact> DocumentArtefacts { get; set; }
        public virtual DbSet<Documenttype> Documenttypes { get; set; }
        public virtual DbSet<Endpoint> Endpoints { get; set; }
        public virtual DbSet<EndpointRole> EndpointRoles { get; set; }
        public virtual DbSet<Endpointgroup> Endpointgroups { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Eventtype> Eventtypes { get; set; }
        public virtual DbSet<Examination> Examinations { get; set; }
        public virtual DbSet<ExaminationArtefact> ExaminationArtefacts { get; set; }
        public virtual DbSet<ExaminationConclusion> ExaminationConclusions { get; set; }
        public virtual DbSet<ExaminationExaminationgroup> ExaminationExaminationgroups { get; set; }
        public virtual DbSet<Examinationgroup> Examinationgroups { get; set; }
        public virtual DbSet<ExaminationsTable> ExaminationsTables { get; set; }
        public virtual DbSet<Logmessage> Logmessages { get; set; }
        public virtual DbSet<Measure> Measures { get; set; }
        public virtual DbSet<Measurerange> Measureranges { get; set; }
        public virtual DbSet<Measuretype> Measuretypes { get; set; }
        public virtual DbSet<Metering> Meterings { get; set; }
        public virtual DbSet<Notificationsendertype> Notificationsendertypes { get; set; }
        public virtual DbSet<NotificationsendertypeSubscription> NotificationsendertypeSubscriptions { get; set; }
        public virtual DbSet<Orgunit> Orgunits { get; set; }
        public virtual DbSet<Password> Passwords { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<PersonArtefact> PersonArtefacts { get; set; }
        public virtual DbSet<PersonPgroup> PersonPgroups { get; set; }
        public virtual DbSet<PersonRole> PersonRoles { get; set; }
        public virtual DbSet<Personunblockrequest> Personunblockrequests { get; set; }
        public virtual DbSet<Pgroup> Pgroups { get; set; }
        public virtual DbSet<PgroupMeasurerange> PgroupMeasureranges { get; set; }
        public virtual DbSet<Prohibitreason> Prohibitreasons { get; set; }
        public virtual DbSet<Pupilconfig> Pupilconfigs { get; set; }
        public virtual DbSet<PupilconfigArtefact> PupilconfigArtefacts { get; set; }
        public virtual DbSet<Pupilmeasure> Pupilmeasures { get; set; }
        public virtual DbSet<Pupilparameter> Pupilparameters { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<RoleAnswerabletype> RoleAnswerabletypes { get; set; }
        public virtual DbSet<Rolesubscription> Rolesubscriptions { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<Shift> Shifts { get; set; }
        public virtual DbSet<Software> Softwares { get; set; }
        public virtual DbSet<Subscription> Subscriptions { get; set; }
        public virtual DbSet<SubscriptionOrgunit> SubscriptionOrgunits { get; set; }
        public virtual DbSet<Telegramidentity> Telegramidentities { get; set; }
        public virtual DbSet<Terminal> Terminals { get; set; }
        public virtual DbSet<TerminalArtefact> TerminalArtefacts { get; set; }
        public virtual DbSet<TerminalchildorgunitTable> TerminalchildorgunitTables { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Xchunkstorage> Xchunkstorages { get; set; }
        public virtual DbSet<Xconstraintschecksum> Xconstraintschecksums { get; set; }
        public virtual DbSet<Xloblinkcount> Xloblinkcounts { get; set; }
        public virtual DbSet<Xsessionvar> Xsessionvars { get; set; }
        public virtual DbSet<Xversioninfostorage> Xversioninfostorages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Host=100.128.0.1;Port=1433;Database=newmed2_docker;Username=telegrambot;Password=rhe5oh");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresExtension("dblink")
                .HasPostgresExtension("tablefunc")
                .HasPostgresExtension("uuid-ossp")
                .HasAnnotation("Relational:Collation", "en_US.utf8");

            modelBuilder.Entity<Actionrequest>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("pk_actionrequest");

                entity.ToTable("actionrequest");

                entity.HasIndex(e => e.Creator, "idx_actionrequest_creator");

                entity.HasIndex(e => e.Responsibleperson, "idx_actionrequest_responsibleperson");

                entity.Property(e => e.Objectid)
                    .ValueGeneratedNever()
                    .HasColumnName("objectid");

                entity.Property(e => e.Createddt)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("createddt")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Creator).HasColumnName("creator");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.Discr)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("_discr");

                entity.Property(e => e.Responsibleperson).HasColumnName("responsibleperson");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Updateddt)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("updateddt");

                entity.HasOne(d => d.CreatorNavigation)
                    .WithMany(p => p.ActionrequestCreatorNavigations)
                    .HasForeignKey(d => d.Creator)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_actionrequest_creator");

                entity.HasOne(d => d.ResponsiblepersonNavigation)
                    .WithMany(p => p.ActionrequestResponsiblepersonNavigations)
                    .HasForeignKey(d => d.Responsibleperson)
                    .HasConstraintName("fk_actionrequest_responsibleperson");
            });

            modelBuilder.Entity<Additionalvalue>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("pk_additionalvalue");

                entity.ToTable("additionalvalue");

                entity.HasIndex(e => e.Metering, "idx_additionalvalue_metering");

                entity.Property(e => e.Objectid)
                    .ValueGeneratedNever()
                    .HasColumnName("objectid");

                entity.Property(e => e.Metering).HasColumnName("metering");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Value).HasColumnName("value");

                entity.HasOne(d => d.MeteringNavigation)
                    .WithMany(p => p.Additionalvalues)
                    .HasForeignKey(d => d.Metering)
                    .HasConstraintName("fk_additionalvalue_metering");
            });

            modelBuilder.Entity<Algorithm>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("pk_algorithm");

                entity.ToTable("algorithm");

                entity.HasIndex(e => new { e.Version, e.Type }, "algorithm_idx_versiontype")
                    .IsUnique();

                entity.HasIndex(e => e.Type, "ux_algorithm_idx_versiontype_2")
                    .HasFilter("(version IS NULL)");

                entity.Property(e => e.Objectid)
                    .ValueGeneratedNever()
                    .HasColumnName("objectid");

                entity.Property(e => e.Comment)
                    .HasMaxLength(1024)
                    .HasColumnName("comment");

                entity.Property(e => e.Createddt)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("createddt");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Version)
                    .HasMaxLength(255)
                    .HasColumnName("version");
            });

            modelBuilder.Entity<Answer>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("pk_answer");

                entity.ToTable("answer");

                entity.HasIndex(e => e.Examination, "idx_answer_examination");

                entity.HasIndex(e => e.Question, "idx_answer_question");

                entity.Property(e => e.Objectid)
                    .ValueGeneratedNever()
                    .HasColumnName("objectid");

                entity.Property(e => e.Comment)
                    .HasMaxLength(1024)
                    .HasColumnName("comment");

                entity.Property(e => e.Dt)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("dt")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Examination).HasColumnName("examination");

                entity.Property(e => e.Question).HasColumnName("question");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Validity)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("validity");

                entity.Property(e => e.Value).HasColumnName("value");

                entity.HasOne(d => d.ExaminationNavigation)
                    .WithMany(p => p.Answers)
                    .HasForeignKey(d => d.Examination)
                    .HasConstraintName("fk_answer_examination");

                entity.HasOne(d => d.QuestionNavigation)
                    .WithMany(p => p.Answers)
                    .HasForeignKey(d => d.Question)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_answer_question");
            });

            modelBuilder.Entity<Answerable>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("pk_answerable");

                entity.ToTable("answerable");

                entity.HasIndex(e => e.Orgunit, "idx_answerable_orgunit");

                entity.HasIndex(e => e.Person, "idx_answerable_person");

                entity.HasIndex(e => e.Type, "idx_answerable_type");

                entity.Property(e => e.Objectid)
                    .ValueGeneratedNever()
                    .HasColumnName("objectid");

                entity.Property(e => e.Orgunit).HasColumnName("orgunit");

                entity.Property(e => e.Person).HasColumnName("person");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.HasOne(d => d.OrgunitNavigation)
                    .WithMany(p => p.Answerables)
                    .HasForeignKey(d => d.Orgunit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_answerable_orgunit");

                entity.HasOne(d => d.PersonNavigation)
                    .WithMany(p => p.Answerables)
                    .HasForeignKey(d => d.Person)
                    .HasConstraintName("fk_answerable_person");

                entity.HasOne(d => d.TypeNavigation)
                    .WithMany(p => p.Answerables)
                    .HasForeignKey(d => d.Type)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_answerable_type");
            });

            modelBuilder.Entity<AnswerableorgunitTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("answerableorgunit_table", "pg_temp_7");

                entity.Property(e => e.Objectid).HasColumnName("objectid");
            });

            modelBuilder.Entity<Answerabletype>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("pk_answerabletype");

                entity.ToTable("answerabletype");

                entity.HasIndex(e => e.Name, "answerabletype_idx_name")
                    .IsUnique();

                entity.Property(e => e.Objectid)
                    .ValueGeneratedNever()
                    .HasColumnName("objectid");

                entity.Property(e => e.Description)
                    .HasMaxLength(1024)
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<Answertemplate>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("pk_answertemplate");

                entity.ToTable("answertemplate");

                entity.HasIndex(e => e.Question, "idx_answertemplate_question");

                entity.Property(e => e.Objectid)
                    .ValueGeneratedNever()
                    .HasColumnName("objectid");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.Mincommentlength).HasColumnName("mincommentlength");

                entity.Property(e => e.Question).HasColumnName("question");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Value).HasColumnName("value");

                entity.HasOne(d => d.QuestionNavigation)
                    .WithMany(p => p.Answertemplates)
                    .HasForeignKey(d => d.Question)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_answertemplate_question");
            });

            modelBuilder.Entity<Appcontstant>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("pk_appcontstant");

                entity.ToTable("appcontstant");

                entity.Property(e => e.Objectid)
                    .ValueGeneratedNever()
                    .HasColumnName("objectid");

                entity.Property(e => e.Domaintype)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("domaintype");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Shownfield)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("shownfield");

                entity.Property(e => e.Shownvalue)
                    .HasMaxLength(255)
                    .HasColumnName("shownvalue");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<Artefact>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("pk_artefact");

                entity.ToTable("artefact");

                entity.HasIndex(e => e.Shift, "idx_artefact_shift");

                entity.HasIndex(e => e.Software, "idx_artefact_software");

                entity.HasIndex(e => e.Type, "idx_artefact_type");

                entity.Property(e => e.Objectid)
                    .ValueGeneratedNever()
                    .HasColumnName("objectid");

                entity.Property(e => e.Binary)
                    .HasColumnType("oid")
                    .HasColumnName("binary");

                entity.Property(e => e.Comment)
                    .HasMaxLength(1024)
                    .HasColumnName("comment");

                entity.Property(e => e.Dt)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("dt")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Flags).HasColumnName("flags");

                entity.Property(e => e.Number).HasColumnName("number");

                entity.Property(e => e.Shift).HasColumnName("shift");

                entity.Property(e => e.Software).HasColumnName("software");

                entity.Property(e => e.Storageid)
                    .HasMaxLength(255)
                    .HasColumnName("storageid");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.HasOne(d => d.BinaryNavigation)
                    .WithMany(p => p.Artefacts)
                    .HasForeignKey(d => d.Binary)
                    .HasConstraintName("fk_artefact_binary");

                entity.HasOne(d => d.ShiftNavigation)
                    .WithMany(p => p.Artefacts)
                    .HasForeignKey(d => d.Shift)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_artefact_shift");

                entity.HasOne(d => d.SoftwareNavigation)
                    .WithMany(p => p.Artefacts)
                    .HasForeignKey(d => d.Software)
                    .HasConstraintName("fk_artefact_software");

                entity.HasOne(d => d.TypeNavigation)
                    .WithMany(p => p.Artefacts)
                    .HasForeignKey(d => d.Type)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_artefact_type");
            });

            modelBuilder.Entity<Artefacttype>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("pk_artefacttype");

                entity.ToTable("artefacttype");

                entity.HasIndex(e => e.Name, "artefacttype_idx_name")
                    .IsUnique();

                entity.Property(e => e.Objectid)
                    .ValueGeneratedNever()
                    .HasColumnName("objectid");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<Authenticity>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("pk_authenticity");

                entity.ToTable("authenticity");

                entity.HasIndex(e => e.Person, "idx_authenticity_person");

                entity.HasIndex(e => e.Type, "idx_authenticity_type");

                entity.Property(e => e.Objectid)
                    .ValueGeneratedNever()
                    .HasColumnName("objectid");

                entity.Property(e => e.Person).HasColumnName("person");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Value)
                    .HasMaxLength(1024)
                    .HasColumnName("value");

                entity.HasOne(d => d.PersonNavigation)
                    .WithMany(p => p.Authenticities)
                    .HasForeignKey(d => d.Person)
                    .HasConstraintName("fk_authenticity_person");

                entity.HasOne(d => d.TypeNavigation)
                    .WithMany(p => p.Authenticities)
                    .HasForeignKey(d => d.Type)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_authenticity_type");
            });

            modelBuilder.Entity<Authenticitytype>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("pk_authenticitytype");

                entity.ToTable("authenticitytype");

                entity.HasIndex(e => e.Name, "authenticitytype_idx_name")
                    .IsUnique();

                entity.Property(e => e.Objectid)
                    .ValueGeneratedNever()
                    .HasColumnName("objectid");

                entity.Property(e => e.Description)
                    .HasMaxLength(1024)
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<Block>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("pk_block");

                entity.ToTable("block");

                entity.HasIndex(e => e.Creator, "idx_block_creator");

                entity.HasIndex(e => e.Examination, "idx_block_examination");

                entity.HasIndex(e => e.Patient, "idx_block_patient");

                entity.HasIndex(e => e.Unblockedperson, "idx_block_unblockedperson");

                entity.Property(e => e.Objectid)
                    .ValueGeneratedNever()
                    .HasColumnName("objectid");

                entity.Property(e => e.Comment)
                    .HasMaxLength(1024)
                    .HasColumnName("comment");

                entity.Property(e => e.Creationcomment)
                    .HasMaxLength(255)
                    .HasColumnName("creationcomment");

                entity.Property(e => e.Creationdt)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("creationdt");

                entity.Property(e => e.Creator).HasColumnName("creator");

                entity.Property(e => e.Examination).HasColumnName("examination");

                entity.Property(e => e.Patient).HasColumnName("patient");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Unblockdt)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("unblockdt");

                entity.Property(e => e.Unblockedperson).HasColumnName("unblockedperson");

                entity.HasOne(d => d.CreatorNavigation)
                    .WithMany(p => p.BlockCreatorNavigations)
                    .HasForeignKey(d => d.Creator)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_block_creator");

                entity.HasOne(d => d.ExaminationNavigation)
                    .WithMany(p => p.Blocks)
                    .HasForeignKey(d => d.Examination)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_block_examination");

                entity.HasOne(d => d.PatientNavigation)
                    .WithMany(p => p.BlockPatientNavigations)
                    .HasForeignKey(d => d.Patient)
                    .HasConstraintName("fk_block_patient");

                entity.HasOne(d => d.UnblockedpersonNavigation)
                    .WithMany(p => p.BlockUnblockedpersonNavigations)
                    .HasForeignKey(d => d.Unblockedperson)
                    .HasConstraintName("fk_block_unblockedperson");
            });

            modelBuilder.Entity<Calcvalue>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("pk_calcvalue");

                entity.ToTable("calcvalue");

                entity.HasIndex(e => e.Measure, "idx_calcvalue_measure");

                entity.Property(e => e.Objectid)
                    .ValueGeneratedNever()
                    .HasColumnName("objectid");

                entity.Property(e => e.Isleft).HasColumnName("isleft");

                entity.Property(e => e.Measure).HasColumnName("measure");

                entity.Property(e => e.Time).HasColumnName("time");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Value).HasColumnName("value");

                entity.HasOne(d => d.MeasureNavigation)
                    .WithMany(p => p.Calcvalues)
                    .HasForeignKey(d => d.Measure)
                    .HasConstraintName("fk_calcvalue_measure");
            });

            modelBuilder.Entity<ChildorgunitTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("childorgunit_table", "pg_temp_7");

                entity.Property(e => e.Objectid).HasColumnName("objectid");
            });

            modelBuilder.Entity<Commentpattern>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("pk_commentpattern");

                entity.ToTable("commentpattern");

                entity.HasIndex(e => e.Prohibitreason, "idx_commentpattern_prohibitreason");

                entity.Property(e => e.Objectid)
                    .ValueGeneratedNever()
                    .HasColumnName("objectid");

                entity.Property(e => e.Number).HasColumnName("number");

                entity.Property(e => e.Prohibitreason).HasColumnName("prohibitreason");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(1024)
                    .HasColumnName("value");

                entity.HasOne(d => d.ProhibitreasonNavigation)
                    .WithMany(p => p.Commentpatterns)
                    .HasForeignKey(d => d.Prohibitreason)
                    .HasConstraintName("fk_commentpattern_prohibitreason");
            });

            modelBuilder.Entity<Conclusion>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("pk_conclusion");

                entity.ToTable("conclusion");

                entity.HasIndex(e => e.Person, "idx_conclusion_person");

                entity.HasIndex(e => e.Prohibitreason, "idx_conclusion_prohibitreason");

                entity.HasIndex(e => e.Role, "idx_conclusion_role");

                entity.Property(e => e.Objectid)
                    .ValueGeneratedNever()
                    .HasColumnName("objectid");

                entity.Property(e => e.Comment)
                    .HasMaxLength(1024)
                    .HasColumnName("comment");

                entity.Property(e => e.Decision).HasColumnName("decision");

                entity.Property(e => e.Person).HasColumnName("person");

                entity.Property(e => e.Prohibitreason).HasColumnName("prohibitreason");

                entity.Property(e => e.Role).HasColumnName("role");

                entity.Property(e => e.Signaturehash)
                    .HasMaxLength(255)
                    .HasColumnName("signaturehash");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasDefaultValueSql("1");

                entity.HasOne(d => d.PersonNavigation)
                    .WithMany(p => p.Conclusions)
                    .HasForeignKey(d => d.Person)
                    .HasConstraintName("fk_conclusion_person");

                entity.HasOne(d => d.ProhibitreasonNavigation)
                    .WithMany(p => p.Conclusions)
                    .HasForeignKey(d => d.Prohibitreason)
                    .HasConstraintName("fk_conclusion_prohibitreason");

                entity.HasOne(d => d.RoleNavigation)
                    .WithMany(p => p.Conclusions)
                    .HasForeignKey(d => d.Role)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_conclusion_role");
            });

            modelBuilder.Entity<Conversation>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("pk_conversation");

                entity.ToTable("conversation");

                entity.HasIndex(e => e.Event, "idx_conversation_event");

                entity.HasIndex(e => e.Eventtype, "idx_conversation_eventtype");

                entity.HasIndex(e => e.Person, "idx_conversation_person");

                entity.Property(e => e.Objectid)
                    .ValueGeneratedNever()
                    .HasColumnName("objectid");

                entity.Property(e => e.Dialogstate).HasColumnName("dialogstate");

                entity.Property(e => e.Dt)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("dt");

                entity.Property(e => e.Event).HasColumnName("event");

                entity.Property(e => e.Eventtype).HasColumnName("eventtype");

                entity.Property(e => e.Number).HasColumnName("number");

                entity.Property(e => e.Person).HasColumnName("person");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasDefaultValueSql("1");

                entity.HasOne(d => d.EventNavigation)
                    .WithMany(p => p.Conversations)
                    .HasForeignKey(d => d.Event)
                    .HasConstraintName("fk_conversation_event");

                entity.HasOne(d => d.EventtypeNavigation)
                    .WithMany(p => p.Conversations)
                    .HasForeignKey(d => d.Eventtype)
                    .HasConstraintName("fk_conversation_eventtype");

                entity.HasOne(d => d.PersonNavigation)
                    .WithMany(p => p.Conversations)
                    .HasForeignKey(d => d.Person)
                    .HasConstraintName("fk_conversation_person");
            });

            modelBuilder.Entity<Device>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("pk_device");

                entity.ToTable("device");

                entity.HasIndex(e => e.Sn, "device_idx_sn")
                    .IsUnique();

                entity.HasIndex(e => e.Devicetype, "idx_device_devicetype");

                entity.HasIndex(e => e.Software, "idx_device_software");

                entity.HasIndex(e => e.Status, "idx_device_status");

                entity.HasIndex(e => e.Terminal, "idx_device_terminal");

                entity.Property(e => e.Objectid)
                    .ValueGeneratedNever()
                    .HasColumnName("objectid");

                entity.Property(e => e.Comment)
                    .HasMaxLength(1024)
                    .HasColumnName("comment");

                entity.Property(e => e.Devicetype).HasColumnName("devicetype");

                entity.Property(e => e.Sn)
                    .HasMaxLength(255)
                    .HasColumnName("sn");

                entity.Property(e => e.Software).HasColumnName("software");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Terminal).HasColumnName("terminal");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasDefaultValueSql("1");

                entity.HasOne(d => d.DevicetypeNavigation)
                    .WithMany(p => p.Devices)
                    .HasForeignKey(d => d.Devicetype)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_device_devicetype");

                entity.HasOne(d => d.SoftwareNavigation)
                    .WithMany(p => p.Devices)
                    .HasForeignKey(d => d.Software)
                    .HasConstraintName("fk_device_software");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.Devices)
                    .HasForeignKey(d => d.Status)
                    .HasConstraintName("fk_device_status");

                entity.HasOne(d => d.TerminalNavigation)
                    .WithMany(p => p.Devices)
                    .HasForeignKey(d => d.Terminal)
                    .HasConstraintName("fk_device_terminal");
            });

            modelBuilder.Entity<DeviceArtefact>(entity =>
            {
                entity.HasKey(e => new { e.Objectid, e.Value })
                    .HasName("pk_device_artefact");

                entity.ToTable("device_artefact");

                entity.HasIndex(e => e.Value, "idx_device_artefact_value");

                entity.Property(e => e.Objectid).HasColumnName("objectid");

                entity.Property(e => e.Value).HasColumnName("value");

                entity.HasOne(d => d.Object)
                    .WithMany(p => p.DeviceArtefacts)
                    .HasForeignKey(d => d.Objectid)
                    .HasConstraintName("fk_device_artefact_objectid");

                entity.HasOne(d => d.ValueNavigation)
                    .WithMany(p => p.DeviceArtefacts)
                    .HasForeignKey(d => d.Value)
                    .HasConstraintName("fk_device_artefact_value");
            });

            modelBuilder.Entity<Devicestatus>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("pk_devicestatus");

                entity.ToTable("devicestatus");

                entity.Property(e => e.Objectid)
                    .ValueGeneratedNever()
                    .HasColumnName("objectid");

                entity.Property(e => e.Currentstatus).HasColumnName("currentstatus");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .HasColumnName("ip");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Updateddt)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("updateddt")
                    .HasDefaultValueSql("now()");
            });

            modelBuilder.Entity<Devicetype>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("pk_devicetype");

                entity.ToTable("devicetype");

                entity.HasIndex(e => e.Name, "devicetype_idx_name")
                    .IsUnique();

                entity.Property(e => e.Objectid)
                    .ValueGeneratedNever()
                    .HasColumnName("objectid");

                entity.Property(e => e.Measureresource).HasColumnName("measureresource");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Serviceperiod).HasColumnName("serviceperiod");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<Doctoractivitystatus>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("pk_doctoractivitystatus");

                entity.ToTable("doctoractivitystatus");

                entity.HasIndex(e => e.Doctor, "idx_doctoractivitystatus_doctor");

                entity.Property(e => e.Objectid)
                    .ValueGeneratedNever()
                    .HasColumnName("objectid");

                entity.Property(e => e.Assignautomatically)
                    .IsRequired()
                    .HasColumnName("assignautomatically")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Doctor).HasColumnName("doctor");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Updateddt)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("updateddt")
                    .HasDefaultValueSql("now()");

                entity.HasOne(d => d.DoctorNavigation)
                    .WithMany(p => p.Doctoractivitystatuses)
                    .HasForeignKey(d => d.Doctor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_doctoractivitystatus_doctor");
            });

            modelBuilder.Entity<Document>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("pk_document");

                entity.ToTable("document");

                entity.HasIndex(e => e.Person, "idx_document_person");

                entity.HasIndex(e => e.Type, "idx_document_type");

                entity.Property(e => e.Objectid)
                    .ValueGeneratedNever()
                    .HasColumnName("objectid");

                entity.Property(e => e.Number)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("number");

                entity.Property(e => e.Person).HasColumnName("person");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.HasOne(d => d.PersonNavigation)
                    .WithMany(p => p.Documents)
                    .HasForeignKey(d => d.Person)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_document_person");

                entity.HasOne(d => d.TypeNavigation)
                    .WithMany(p => p.Documents)
                    .HasForeignKey(d => d.Type)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_document_type");
            });

            modelBuilder.Entity<DocumentArtefact>(entity =>
            {
                entity.HasKey(e => new { e.Objectid, e.Value })
                    .HasName("pk_document_artefact");

                entity.ToTable("document_artefact");

                entity.HasIndex(e => e.Value, "idx_document_artefact_value");

                entity.Property(e => e.Objectid).HasColumnName("objectid");

                entity.Property(e => e.Value).HasColumnName("value");

                entity.HasOne(d => d.Object)
                    .WithMany(p => p.DocumentArtefacts)
                    .HasForeignKey(d => d.Objectid)
                    .HasConstraintName("fk_document_artefact_objectid");

                entity.HasOne(d => d.ValueNavigation)
                    .WithMany(p => p.DocumentArtefacts)
                    .HasForeignKey(d => d.Value)
                    .HasConstraintName("fk_document_artefact_value");
            });

            modelBuilder.Entity<Documenttype>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("pk_documenttype");

                entity.ToTable("documenttype");

                entity.HasIndex(e => e.Name, "documenttype_idx_name")
                    .IsUnique();

                entity.Property(e => e.Objectid)
                    .ValueGeneratedNever()
                    .HasColumnName("objectid");

                entity.Property(e => e.Checkpattern)
                    .HasMaxLength(255)
                    .HasColumnName("checkpattern");

                entity.Property(e => e.Enabled).HasColumnName("enabled");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<Endpoint>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("pk_endpoint");

                entity.ToTable("endpoint");

                entity.HasIndex(e => e.Endpointgroup, "idx_endpoint_endpointgroup");

                entity.Property(e => e.Objectid)
                    .ValueGeneratedNever()
                    .HasColumnName("objectid");

                entity.Property(e => e.Authrequired)
                    .IsRequired()
                    .HasColumnName("authrequired")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Endpointgroup).HasColumnName("endpointgroup");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasDefaultValueSql("1");

                entity.HasOne(d => d.EndpointgroupNavigation)
                    .WithMany(p => p.Endpoints)
                    .HasForeignKey(d => d.Endpointgroup)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_endpoint_endpointgroup");
            });

            modelBuilder.Entity<EndpointRole>(entity =>
            {
                entity.HasKey(e => new { e.Objectid, e.Value })
                    .HasName("pk_endpoint_role");

                entity.ToTable("endpoint_role");

                entity.HasIndex(e => e.Value, "idx_endpoint_role_value");

                entity.Property(e => e.Objectid).HasColumnName("objectid");

                entity.Property(e => e.Value).HasColumnName("value");

                entity.HasOne(d => d.Object)
                    .WithMany(p => p.EndpointRoles)
                    .HasForeignKey(d => d.Objectid)
                    .HasConstraintName("fk_endpoint_role_objectid");

                entity.HasOne(d => d.ValueNavigation)
                    .WithMany(p => p.EndpointRoles)
                    .HasForeignKey(d => d.Value)
                    .HasConstraintName("fk_endpoint_role_value");
            });

            modelBuilder.Entity<Endpointgroup>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("pk_endpointgroup");

                entity.ToTable("endpointgroup");

                entity.HasIndex(e => new { e.Prefix, e.Method }, "endpointgroup_idx_prefixmethod")
                    .IsUnique();

                entity.Property(e => e.Objectid)
                    .ValueGeneratedNever()
                    .HasColumnName("objectid");

                entity.Property(e => e.Method)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("method");

                entity.Property(e => e.Prefix)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("prefix");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<Event>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("pk_event");

                entity.ToTable("event");

                entity.HasIndex(e => e.Eventtype, "idx_event_eventtype");

                entity.HasIndex(e => e.Examination, "idx_event_examination");

                entity.HasIndex(e => e.Relatedconversation, "idx_event_relatedconversation");

                entity.HasIndex(e => e.Terminal, "idx_event_terminal");

                entity.Property(e => e.Objectid)
                    .ValueGeneratedNever()
                    .HasColumnName("objectid");

                entity.Property(e => e.Eventtype).HasColumnName("eventtype");

                entity.Property(e => e.Examination).HasColumnName("examination");

                entity.Property(e => e.Invoked).HasColumnName("invoked");

                entity.Property(e => e.Invokedt)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("invokedt");

                entity.Property(e => e.Isactiveproblem).HasColumnName("isactiveproblem");

                entity.Property(e => e.Relatedconversation).HasColumnName("relatedconversation");

                entity.Property(e => e.Terminal).HasColumnName("terminal");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasDefaultValueSql("1");

                entity.HasOne(d => d.EventtypeNavigation)
                    .WithMany(p => p.Events)
                    .HasForeignKey(d => d.Eventtype)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_event_eventtype");

                entity.HasOne(d => d.ExaminationNavigation)
                    .WithMany(p => p.Events)
                    .HasForeignKey(d => d.Examination)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_event_examination");

                entity.HasOne(d => d.RelatedconversationNavigation)
                    .WithMany(p => p.Events)
                    .HasForeignKey(d => d.Relatedconversation)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_event_relatedconversation");

                entity.HasOne(d => d.TerminalNavigation)
                    .WithMany(p => p.Events)
                    .HasForeignKey(d => d.Terminal)
                    .HasConstraintName("fk_event_terminal");
            });

            modelBuilder.Entity<Eventtype>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("pk_eventtype");

                entity.ToTable("eventtype");

                entity.HasIndex(e => e.Name, "eventtype_idx_name")
                    .IsUnique();

                entity.Property(e => e.Objectid)
                    .ValueGeneratedNever()
                    .HasColumnName("objectid");

                entity.Property(e => e.Description)
                    .HasMaxLength(1024)
                    .HasColumnName("description");

                entity.Property(e => e.Invokedelay).HasColumnName("invokedelay");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<Examination>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("pk_examination");

                entity.ToTable("examination");

                entity.HasIndex(e => e.Employee, "idx_examination_employee");

                entity.HasIndex(e => e.Patient, "idx_examination_patient");

                entity.HasIndex(e => e.Shift, "idx_examination_shift");

                entity.HasIndex(e => e.Software, "idx_examination_software");

                entity.HasIndex(e => e.Terminal, "idx_examination_terminal");

                entity.Property(e => e.Objectid)
                    .ValueGeneratedNever()
                    .HasColumnName("objectid");

                entity.Property(e => e.Accessstatus).HasColumnName("accessstatus");

                entity.Property(e => e.Dt)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("dt")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Employee).HasColumnName("employee");

                entity.Property(e => e.Enqueuedt)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("enqueuedt");

                entity.Property(e => e.Finishdt)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("finishdt");

                entity.Property(e => e.Patient).HasColumnName("patient");

                entity.Property(e => e.Shift).HasColumnName("shift");

                entity.Property(e => e.Software).HasColumnName("software");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Terminal).HasColumnName("terminal");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.HasOne(d => d.EmployeeNavigation)
                    .WithMany(p => p.ExaminationEmployeeNavigations)
                    .HasForeignKey(d => d.Employee)
                    .HasConstraintName("fk_examination_employee");

                entity.HasOne(d => d.PatientNavigation)
                    .WithMany(p => p.ExaminationPatientNavigations)
                    .HasForeignKey(d => d.Patient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_examination_patient");

                entity.HasOne(d => d.ShiftNavigation)
                    .WithMany(p => p.Examinations)
                    .HasForeignKey(d => d.Shift)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_examination_shift");

                entity.HasOne(d => d.SoftwareNavigation)
                    .WithMany(p => p.Examinations)
                    .HasForeignKey(d => d.Software)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_examination_software");

                entity.HasOne(d => d.TerminalNavigation)
                    .WithMany(p => p.Examinations)
                    .HasForeignKey(d => d.Terminal)
                    .HasConstraintName("fk_examination_terminal");
            });

            modelBuilder.Entity<ExaminationArtefact>(entity =>
            {
                entity.HasKey(e => new { e.Objectid, e.Value })
                    .HasName("pk_examination_artefact");

                entity.ToTable("examination_artefact");

                entity.HasIndex(e => e.Value, "idx_examination_artefact_value");

                entity.Property(e => e.Objectid).HasColumnName("objectid");

                entity.Property(e => e.Value).HasColumnName("value");

                entity.HasOne(d => d.Object)
                    .WithMany(p => p.ExaminationArtefacts)
                    .HasForeignKey(d => d.Objectid)
                    .HasConstraintName("fk_examination_artefact_objectid");

                entity.HasOne(d => d.ValueNavigation)
                    .WithMany(p => p.ExaminationArtefacts)
                    .HasForeignKey(d => d.Value)
                    .HasConstraintName("fk_examination_artefact_value");
            });

            modelBuilder.Entity<ExaminationConclusion>(entity =>
            {
                entity.HasKey(e => new { e.Objectid, e.Value })
                    .HasName("pk_examination_conclusion");

                entity.ToTable("examination_conclusion");

                entity.HasIndex(e => e.Value, "idx_examination_conclusion_value");

                entity.Property(e => e.Objectid).HasColumnName("objectid");

                entity.Property(e => e.Value).HasColumnName("value");

                entity.HasOne(d => d.Object)
                    .WithMany(p => p.ExaminationConclusions)
                    .HasForeignKey(d => d.Objectid)
                    .HasConstraintName("fk_examination_conclusion_objectid");

                entity.HasOne(d => d.ValueNavigation)
                    .WithMany(p => p.ExaminationConclusions)
                    .HasForeignKey(d => d.Value)
                    .HasConstraintName("fk_examination_conclusion_value");
            });

            modelBuilder.Entity<ExaminationExaminationgroup>(entity =>
            {
                entity.HasKey(e => new { e.Objectid, e.Value })
                    .HasName("pk_examination_examinationgroup");

                entity.ToTable("examination_examinationgroup");

                entity.HasIndex(e => e.Value, "idx_examination_examinationgroup_value");

                entity.Property(e => e.Objectid).HasColumnName("objectid");

                entity.Property(e => e.Value).HasColumnName("value");

                entity.HasOne(d => d.Object)
                    .WithMany(p => p.ExaminationExaminationgroups)
                    .HasForeignKey(d => d.Objectid)
                    .HasConstraintName("fk_examination_examinationgroup_objectid");

                entity.HasOne(d => d.ValueNavigation)
                    .WithMany(p => p.ExaminationExaminationgroups)
                    .HasForeignKey(d => d.Value)
                    .HasConstraintName("fk_examination_examinationgroup_value");
            });

            modelBuilder.Entity<Examinationgroup>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("pk_examinationgroup");

                entity.ToTable("examinationgroup");

                entity.Property(e => e.Objectid)
                    .ValueGeneratedNever()
                    .HasColumnName("objectid");

                entity.Property(e => e.Description)
                    .HasMaxLength(1024)
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<ExaminationsTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("examinations_table", "pg_temp_7");

                entity.Property(e => e.Objectid).HasColumnName("objectid");

                entity.Property(e => e.Totalrowcount).HasColumnName("totalrowcount");
            });

            modelBuilder.Entity<Logmessage>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("pk_logmessage");

                entity.ToTable("logmessage");

                entity.HasIndex(e => e.Device, "idx_logmessage_device");

                entity.HasIndex(e => e.Person, "idx_logmessage_person");

                entity.HasIndex(e => e.Terminal, "idx_logmessage_terminal");

                entity.Property(e => e.Objectid)
                    .ValueGeneratedNever()
                    .HasColumnName("objectid");

                entity.Property(e => e.Classname)
                    .HasMaxLength(255)
                    .HasColumnName("classname");

                entity.Property(e => e.Device).HasColumnName("device");

                entity.Property(e => e.Dt)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("dt")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .HasColumnName("ip");

                entity.Property(e => e.Level).HasColumnName("level");

                entity.Property(e => e.Linenumber).HasColumnName("linenumber");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnName("message");

                entity.Property(e => e.Methodname)
                    .HasMaxLength(255)
                    .HasColumnName("methodname");

                entity.Property(e => e.Person).HasColumnName("person");

                entity.Property(e => e.Terminal).HasColumnName("terminal");

                entity.Property(e => e.Thread)
                    .HasMaxLength(255)
                    .HasColumnName("thread");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasDefaultValueSql("1");

                entity.HasOne(d => d.DeviceNavigation)
                    .WithMany(p => p.Logmessages)
                    .HasForeignKey(d => d.Device)
                    .HasConstraintName("fk_logmessage_device");

                entity.HasOne(d => d.PersonNavigation)
                    .WithMany(p => p.Logmessages)
                    .HasForeignKey(d => d.Person)
                    .HasConstraintName("fk_logmessage_person");

                entity.HasOne(d => d.TerminalNavigation)
                    .WithMany(p => p.Logmessages)
                    .HasForeignKey(d => d.Terminal)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_logmessage_terminal");
            });

            modelBuilder.Entity<Measure>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("pk_measure");

                entity.ToTable("measure");

                entity.HasIndex(e => e.Devicetype, "idx_measure_devicetype");

                entity.HasIndex(e => e.Examination, "idx_measure_examination");

                entity.HasIndex(e => e.Measurerange, "idx_measure_measurerange");

                entity.HasIndex(e => e.Measuretype, "idx_measure_measuretype");

                entity.Property(e => e.Objectid)
                    .ValueGeneratedNever()
                    .HasColumnName("objectid");

                entity.Property(e => e.Devicetype).HasColumnName("devicetype");

                entity.Property(e => e.Discr)
                    .IsRequired()
                    .HasMaxLength(12)
                    .HasColumnName("_discr");

                entity.Property(e => e.Dt)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("dt")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Examination).HasColumnName("examination");

                entity.Property(e => e.Flags).HasColumnName("flags");

                entity.Property(e => e.Isfail).HasColumnName("isfail");

                entity.Property(e => e.Measurerange).HasColumnName("measurerange");

                entity.Property(e => e.Measuretype).HasColumnName("measuretype");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("value");

                entity.HasOne(d => d.DevicetypeNavigation)
                    .WithMany(p => p.Measures)
                    .HasForeignKey(d => d.Devicetype)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_measure_devicetype");

                entity.HasOne(d => d.ExaminationNavigation)
                    .WithMany(p => p.Measures)
                    .HasForeignKey(d => d.Examination)
                    .HasConstraintName("fk_measure_examination");

                entity.HasOne(d => d.MeasurerangeNavigation)
                    .WithMany(p => p.Measures)
                    .HasForeignKey(d => d.Measurerange)
                    .HasConstraintName("fk_measure_measurerange");

                entity.HasOne(d => d.MeasuretypeNavigation)
                    .WithMany(p => p.Measures)
                    .HasForeignKey(d => d.Measuretype)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_measure_measuretype");
            });

            modelBuilder.Entity<Measurerange>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("pk_measurerange");

                entity.ToTable("measurerange");

                entity.HasIndex(e => e.Devicetype, "idx_measurerange_devicetype");

                entity.HasIndex(e => e.Measuretype, "idx_measurerange_measuretype");

                entity.Property(e => e.Objectid)
                    .ValueGeneratedNever()
                    .HasColumnName("objectid");

                entity.Property(e => e.Color)
                    .HasMaxLength(255)
                    .HasColumnName("color");

                entity.Property(e => e.Comment)
                    .HasMaxLength(1024)
                    .HasColumnName("comment");

                entity.Property(e => e.Devicetype).HasColumnName("devicetype");

                entity.Property(e => e.Isarchive).HasColumnName("isarchive");

                entity.Property(e => e.Isfail).HasColumnName("isfail");

                entity.Property(e => e.Maxvalue).HasColumnName("maxvalue");

                entity.Property(e => e.Measuretype).HasColumnName("measuretype");

                entity.Property(e => e.Minvalue).HasColumnName("minvalue");

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.Property(e => e.Rangename)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("rangename");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasDefaultValueSql("1");

                entity.HasOne(d => d.DevicetypeNavigation)
                    .WithMany(p => p.Measureranges)
                    .HasForeignKey(d => d.Devicetype)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_measurerange_devicetype");

                entity.HasOne(d => d.MeasuretypeNavigation)
                    .WithMany(p => p.Measureranges)
                    .HasForeignKey(d => d.Measuretype)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_measurerange_measuretype");
            });

            modelBuilder.Entity<Measuretype>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("pk_measuretype");

                entity.ToTable("measuretype");

                entity.HasIndex(e => e.Preferreddevicetype, "idx_measuretype_preferreddevicetype");

                entity.HasIndex(e => e.Name, "measuretype_idx_name")
                    .IsUnique();

                entity.Property(e => e.Objectid)
                    .ValueGeneratedNever()
                    .HasColumnName("objectid");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Preferreddevicetype).HasColumnName("preferreddevicetype");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasDefaultValueSql("1");

                entity.HasOne(d => d.PreferreddevicetypeNavigation)
                    .WithMany(p => p.Measuretypes)
                    .HasForeignKey(d => d.Preferreddevicetype)
                    .HasConstraintName("fk_measuretype_preferreddevicetype");
            });

            modelBuilder.Entity<Metering>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("pk_metering");

                entity.ToTable("metering");

                entity.HasIndex(e => e.Measure, "idx_metering_measure");

                entity.Property(e => e.Objectid)
                    .ValueGeneratedNever()
                    .HasColumnName("objectid");

                entity.Property(e => e.Alpha).HasColumnName("alpha");

                entity.Property(e => e.D).HasColumnName("d");

                entity.Property(e => e.Isleft).HasColumnName("isleft");

                entity.Property(e => e.Isoriginal).HasColumnName("isoriginal");

                entity.Property(e => e.Measure).HasColumnName("measure");

                entity.Property(e => e.Time).HasColumnName("time");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.X).HasColumnName("x");

                entity.Property(e => e.Y).HasColumnName("y");

                entity.HasOne(d => d.MeasureNavigation)
                    .WithMany(p => p.Meterings)
                    .HasForeignKey(d => d.Measure)
                    .HasConstraintName("fk_metering_measure");
            });

            modelBuilder.Entity<Notificationsendertype>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("pk_notificationsendertype");

                entity.ToTable("notificationsendertype");

                entity.HasIndex(e => e.Name, "notificationsendertype_idx_name")
                    .IsUnique();

                entity.Property(e => e.Objectid)
                    .ValueGeneratedNever()
                    .HasColumnName("objectid");

                entity.Property(e => e.Description)
                    .HasMaxLength(1024)
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<NotificationsendertypeSubscription>(entity =>
            {
                entity.HasKey(e => new { e.Objectid, e.Value })
                    .HasName("pk_notificationsendertype_subscription");

                entity.ToTable("notificationsendertype_subscription");

                entity.HasIndex(e => e.Value, "idx_notificationsendertype_subscription_value");

                entity.Property(e => e.Objectid).HasColumnName("objectid");

                entity.Property(e => e.Value).HasColumnName("value");

                entity.HasOne(d => d.Object)
                    .WithMany(p => p.NotificationsendertypeSubscriptions)
                    .HasForeignKey(d => d.Objectid)
                    .HasConstraintName("fk_notificationsendertype_subscription_objectid");

                entity.HasOne(d => d.ValueNavigation)
                    .WithMany(p => p.NotificationsendertypeSubscriptions)
                    .HasForeignKey(d => d.Value)
                    .HasConstraintName("fk_notificationsendertype_subscription_value");
            });

            modelBuilder.Entity<Orgunit>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("pk_orgunit");

                entity.ToTable("orgunit");

                entity.HasIndex(e => e.Manager, "idx_orgunit_manager");

                entity.HasIndex(e => e.Parent, "idx_orgunit_parent");

                entity.HasIndex(e => new { e.Name, e.Parent }, "orgunit_idx_nameparent")
                    .IsUnique();

                entity.Property(e => e.Objectid)
                    .ValueGeneratedNever()
                    .HasColumnName("objectid");

                entity.Property(e => e.Description)
                    .HasMaxLength(1024)
                    .HasColumnName("description");

                entity.Property(e => e.Flags).HasColumnName("flags");

                entity.Property(e => e.Manager).HasColumnName("manager");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Parent).HasColumnName("parent");

                entity.Property(e => e.Timezone).HasColumnName("timezone");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasDefaultValueSql("1");

                entity.HasOne(d => d.ManagerNavigation)
                    .WithMany(p => p.Orgunits)
                    .HasForeignKey(d => d.Manager)
                    .HasConstraintName("fk_orgunit_manager");

                entity.HasOne(d => d.ParentNavigation)
                    .WithMany(p => p.InverseParentNavigation)
                    .HasForeignKey(d => d.Parent)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_orgunit_parent");
            });

            modelBuilder.Entity<Password>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("pk_password");

                entity.ToTable("password");

                entity.HasIndex(e => e.Authenticity, "idx_password_authenticity");

                entity.Property(e => e.Objectid)
                    .ValueGeneratedNever()
                    .HasColumnName("objectid");

                entity.Property(e => e.Authenticity).HasColumnName("authenticity");

                entity.Property(e => e.Flags).HasColumnName("flags");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("value");

                entity.HasOne(d => d.AuthenticityNavigation)
                    .WithMany(p => p.Passwords)
                    .HasForeignKey(d => d.Authenticity)
                    .HasConstraintName("fk_password_authenticity");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("pk_person");

                entity.ToTable("person");

                entity.HasIndex(e => e.Orgunit, "idx_person_orgunit");

                entity.Property(e => e.Objectid)
                    .ValueGeneratedNever()
                    .HasColumnName("objectid");

                entity.Property(e => e.Birthday).HasColumnName("birthday");

                entity.Property(e => e.Flags).HasColumnName("flags");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(255)
                    .HasColumnName("fullname");

                entity.Property(e => e.Ismale).HasColumnName("ismale");

                entity.Property(e => e.Number).HasColumnName("number");

                entity.Property(e => e.Orgunit).HasColumnName("orgunit");

                entity.Property(e => e.Profession)
                    .HasMaxLength(255)
                    .HasColumnName("profession");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasDefaultValueSql("1");

                entity.HasOne(d => d.OrgunitNavigation)
                    .WithMany(p => p.People)
                    .HasForeignKey(d => d.Orgunit)
                    .HasConstraintName("fk_person_orgunit");
            });

            modelBuilder.Entity<PersonArtefact>(entity =>
            {
                entity.HasKey(e => new { e.Objectid, e.Value })
                    .HasName("pk_person_artefact");

                entity.ToTable("person_artefact");

                entity.HasIndex(e => e.Value, "idx_person_artefact_value");

                entity.Property(e => e.Objectid).HasColumnName("objectid");

                entity.Property(e => e.Value).HasColumnName("value");

                entity.HasOne(d => d.Object)
                    .WithMany(p => p.PersonArtefacts)
                    .HasForeignKey(d => d.Objectid)
                    .HasConstraintName("fk_person_artefact_objectid");

                entity.HasOne(d => d.ValueNavigation)
                    .WithMany(p => p.PersonArtefacts)
                    .HasForeignKey(d => d.Value)
                    .HasConstraintName("fk_person_artefact_value");
            });

            modelBuilder.Entity<PersonPgroup>(entity =>
            {
                entity.HasKey(e => new { e.Objectid, e.Value })
                    .HasName("pk_person_pgroup");

                entity.ToTable("person_pgroup");

                entity.HasIndex(e => e.Value, "idx_person_pgroup_value");

                entity.Property(e => e.Objectid).HasColumnName("objectid");

                entity.Property(e => e.Value).HasColumnName("value");

                entity.HasOne(d => d.Object)
                    .WithMany(p => p.PersonPgroups)
                    .HasForeignKey(d => d.Objectid)
                    .HasConstraintName("fk_person_pgroup_objectid");

                entity.HasOne(d => d.ValueNavigation)
                    .WithMany(p => p.PersonPgroups)
                    .HasForeignKey(d => d.Value)
                    .HasConstraintName("fk_person_pgroup_value");
            });

            modelBuilder.Entity<PersonRole>(entity =>
            {
                entity.HasKey(e => new { e.Objectid, e.Value })
                    .HasName("pk_person_role");

                entity.ToTable("person_role");

                entity.HasIndex(e => e.Value, "idx_person_role_value");

                entity.Property(e => e.Objectid).HasColumnName("objectid");

                entity.Property(e => e.Value).HasColumnName("value");

                entity.HasOne(d => d.Object)
                    .WithMany(p => p.PersonRoles)
                    .HasForeignKey(d => d.Objectid)
                    .HasConstraintName("fk_person_role_objectid");

                entity.HasOne(d => d.ValueNavigation)
                    .WithMany(p => p.PersonRoles)
                    .HasForeignKey(d => d.Value)
                    .HasConstraintName("fk_person_role_value");
            });

            modelBuilder.Entity<Personunblockrequest>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("pk_personunblockrequest");

                entity.ToTable("personunblockrequest");

                entity.HasIndex(e => e.Persontounblock, "idx_personunblockrequest_persontounblock");

                entity.Property(e => e.Objectid)
                    .ValueGeneratedNever()
                    .HasColumnName("objectid");

                entity.Property(e => e.Persontounblock).HasColumnName("persontounblock");

                entity.HasOne(d => d.Object)
                    .WithOne(p => p.Personunblockrequest)
                    .HasForeignKey<Personunblockrequest>(d => d.Objectid)
                    .HasConstraintName("fk$personunblockrequest");

                entity.HasOne(d => d.PersontounblockNavigation)
                    .WithMany(p => p.Personunblockrequests)
                    .HasForeignKey(d => d.Persontounblock)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_personunblockrequest_persontounblock");
            });

            modelBuilder.Entity<Pgroup>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("pk_pgroup");

                entity.ToTable("pgroup");

                entity.HasIndex(e => e.Name, "pgroup_idx_name")
                    .IsUnique();

                entity.Property(e => e.Objectid)
                    .ValueGeneratedNever()
                    .HasColumnName("objectid");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.Flags).HasColumnName("flags");

                entity.Property(e => e.Isdefault).HasColumnName("isdefault");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<PgroupMeasurerange>(entity =>
            {
                entity.HasKey(e => new { e.Objectid, e.Value })
                    .HasName("pk_pgroup_measurerange");

                entity.ToTable("pgroup_measurerange");

                entity.HasIndex(e => e.Value, "idx_pgroup_measurerange_value");

                entity.Property(e => e.Objectid).HasColumnName("objectid");

                entity.Property(e => e.Value).HasColumnName("value");

                entity.HasOne(d => d.Object)
                    .WithMany(p => p.PgroupMeasureranges)
                    .HasForeignKey(d => d.Objectid)
                    .HasConstraintName("fk_pgroup_measurerange_objectid");

                entity.HasOne(d => d.ValueNavigation)
                    .WithMany(p => p.PgroupMeasureranges)
                    .HasForeignKey(d => d.Value)
                    .HasConstraintName("fk_pgroup_measurerange_value");
            });

            modelBuilder.Entity<Prohibitreason>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("pk_prohibitreason");

                entity.ToTable("prohibitreason");

                entity.HasIndex(e => e.Name, "prohibitreason_idx_name")
                    .IsUnique();

                entity.Property(e => e.Objectid)
                    .ValueGeneratedNever()
                    .HasColumnName("objectid");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.Isarchive).HasColumnName("isarchive");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<Pupilconfig>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("pk_pupilconfig");

                entity.ToTable("pupilconfig");

                entity.HasIndex(e => e.Device, "idx_pupilconfig_device");

                entity.HasIndex(e => e.Software, "idx_pupilconfig_software");

                entity.Property(e => e.Objectid)
                    .ValueGeneratedNever()
                    .HasColumnName("objectid");

                entity.Property(e => e.Comment)
                    .HasMaxLength(1024)
                    .HasColumnName("comment");

                entity.Property(e => e.Commonbrightness).HasColumnName("commonbrightness");

                entity.Property(e => e.Creationdt)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("creationdt")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Device).HasColumnName("device");

                entity.Property(e => e.Flashduration).HasColumnName("flashduration");

                entity.Property(e => e.Gain).HasColumnName("gain");

                entity.Property(e => e.Irleft).HasColumnName("irleft");

                entity.Property(e => e.Irright).HasColumnName("irright");

                entity.Property(e => e.Iscurrent).HasColumnName("iscurrent");

                entity.Property(e => e.Position0x).HasColumnName("position0x");

                entity.Property(e => e.Position0y).HasColumnName("position0y");

                entity.Property(e => e.Position1x).HasColumnName("position1x");

                entity.Property(e => e.Position1y).HasColumnName("position1y");

                entity.Property(e => e.Software).HasColumnName("software");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasDefaultValueSql("1");

                entity.HasOne(d => d.DeviceNavigation)
                    .WithMany(p => p.Pupilconfigs)
                    .HasForeignKey(d => d.Device)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_pupilconfig_device");

                entity.HasOne(d => d.SoftwareNavigation)
                    .WithMany(p => p.Pupilconfigs)
                    .HasForeignKey(d => d.Software)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_pupilconfig_software");
            });

            modelBuilder.Entity<PupilconfigArtefact>(entity =>
            {
                entity.HasKey(e => new { e.Objectid, e.Value, e.K })
                    .HasName("pk_pupilconfig_artefact");

                entity.ToTable("pupilconfig_artefact");

                entity.HasIndex(e => e.Value, "idx_pupilconfig_artefact_value");

                entity.Property(e => e.Objectid).HasColumnName("objectid");

                entity.Property(e => e.Value).HasColumnName("value");

                entity.Property(e => e.K).HasColumnName("k");

                entity.HasOne(d => d.Object)
                    .WithMany(p => p.PupilconfigArtefacts)
                    .HasForeignKey(d => d.Objectid)
                    .HasConstraintName("fk_pupilconfig_artefact_objectid");

                entity.HasOne(d => d.ValueNavigation)
                    .WithMany(p => p.PupilconfigArtefacts)
                    .HasForeignKey(d => d.Value)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_pupilconfig_artefact_value");
            });

            modelBuilder.Entity<Pupilmeasure>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("pk_pupilmeasure");

                entity.ToTable("pupilmeasure");

                entity.HasIndex(e => e.Pupilconfig, "idx_pupilmeasure_pupilconfig");

                entity.HasIndex(e => e.Software, "idx_pupilmeasure_software");

                entity.Property(e => e.Objectid)
                    .ValueGeneratedNever()
                    .HasColumnName("objectid");

                entity.Property(e => e.Confidence).HasColumnName("confidence");

                entity.Property(e => e.Config).HasColumnName("config");

                entity.Property(e => e.Error).HasColumnName("error");

                entity.Property(e => e.Pupilconfig).HasColumnName("pupilconfig");

                entity.Property(e => e.Score).HasColumnName("score");

                entity.Property(e => e.Software).HasColumnName("software");

                entity.HasOne(d => d.Object)
                    .WithOne(p => p.Pupilmeasure)
                    .HasForeignKey<Pupilmeasure>(d => d.Objectid)
                    .HasConstraintName("fk$pupilmeasure");

                entity.HasOne(d => d.PupilconfigNavigation)
                    .WithMany(p => p.Pupilmeasures)
                    .HasForeignKey(d => d.Pupilconfig)
                    .HasConstraintName("fk_pupilmeasure_pupilconfig");

                entity.HasOne(d => d.SoftwareNavigation)
                    .WithMany(p => p.Pupilmeasures)
                    .HasForeignKey(d => d.Software)
                    .HasConstraintName("fk_pupilmeasure_software");
            });

            modelBuilder.Entity<Pupilparameter>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("pk_pupilparameter");

                entity.ToTable("pupilparameter");

                entity.HasIndex(e => e.Measure, "idx_pupilparameter_measure");

                entity.Property(e => e.Objectid)
                    .ValueGeneratedNever()
                    .HasColumnName("objectid");

                entity.Property(e => e.Deviation).HasColumnName("deviation");

                entity.Property(e => e.Isleft).HasColumnName("isleft");

                entity.Property(e => e.Measure).HasColumnName("measure");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Unit).HasColumnName("unit");

                entity.Property(e => e.Value).HasColumnName("value");

                entity.Property(e => e.Valueaverage).HasColumnName("valueaverage");

                entity.Property(e => e.Valuestd).HasColumnName("valuestd");

                entity.HasOne(d => d.MeasureNavigation)
                    .WithMany(p => p.Pupilparameters)
                    .HasForeignKey(d => d.Measure)
                    .HasConstraintName("fk_pupilparameter_measure");
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("pk_question");

                entity.ToTable("question");

                entity.HasIndex(e => e.Prevquestion, "idx_question_prevquestion");

                entity.Property(e => e.Objectid)
                    .ValueGeneratedNever()
                    .HasColumnName("objectid");

                entity.Property(e => e.Answertype).HasColumnName("answertype");

                entity.Property(e => e.Answervalidity).HasColumnName("answervalidity");

                entity.Property(e => e.Flags).HasColumnName("flags");

                entity.Property(e => e.Ordernumber).HasColumnName("ordernumber");

                entity.Property(e => e.Prevquestion).HasColumnName("prevquestion");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(512)
                    .HasColumnName("text");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasDefaultValueSql("1");

                entity.HasOne(d => d.PrevquestionNavigation)
                    .WithMany(p => p.InversePrevquestionNavigation)
                    .HasForeignKey(d => d.Prevquestion)
                    .HasConstraintName("fk_question_prevquestion");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("pk_role");

                entity.ToTable("role");

                entity.HasIndex(e => e.Name, "role_idx_name")
                    .IsUnique();

                entity.Property(e => e.Objectid)
                    .ValueGeneratedNever()
                    .HasColumnName("objectid");

                entity.Property(e => e.Description)
                    .HasMaxLength(1024)
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<RoleAnswerabletype>(entity =>
            {
                entity.HasKey(e => new { e.Objectid, e.Value })
                    .HasName("pk_role_answerabletype");

                entity.ToTable("role_answerabletype");

                entity.HasIndex(e => e.Value, "idx_role_answerabletype_value");

                entity.Property(e => e.Objectid).HasColumnName("objectid");

                entity.Property(e => e.Value).HasColumnName("value");

                entity.HasOne(d => d.Object)
                    .WithMany(p => p.RoleAnswerabletypes)
                    .HasForeignKey(d => d.Objectid)
                    .HasConstraintName("fk_role_answerabletype_objectid");

                entity.HasOne(d => d.ValueNavigation)
                    .WithMany(p => p.RoleAnswerabletypes)
                    .HasForeignKey(d => d.Value)
                    .HasConstraintName("fk_role_answerabletype_value");
            });

            modelBuilder.Entity<Rolesubscription>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("pk_rolesubscription");

                entity.ToTable("rolesubscription");

                entity.HasIndex(e => e.Eventtype, "idx_rolesubscription_eventtype");

                entity.HasIndex(e => e.Role, "idx_rolesubscription_role");

                entity.Property(e => e.Objectid)
                    .ValueGeneratedNever()
                    .HasColumnName("objectid");

                entity.Property(e => e.Enabledbydefault).HasColumnName("enabledbydefault");

                entity.Property(e => e.Eventtype).HasColumnName("eventtype");

                entity.Property(e => e.Role).HasColumnName("role");

                entity.Property(e => e.Subscriptionchannel).HasColumnName("subscriptionchannel");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasDefaultValueSql("1");

                entity.HasOne(d => d.EventtypeNavigation)
                    .WithMany(p => p.Rolesubscriptions)
                    .HasForeignKey(d => d.Eventtype)
                    .HasConstraintName("fk_rolesubscription_eventtype");

                entity.HasOne(d => d.RoleNavigation)
                    .WithMany(p => p.Rolesubscriptions)
                    .HasForeignKey(d => d.Role)
                    .HasConstraintName("fk_rolesubscription_role");
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("pk_service");

                entity.ToTable("service");

                entity.HasIndex(e => e.Device, "idx_service_device");

                entity.HasIndex(e => e.Engineer, "idx_service_engineer");

                entity.Property(e => e.Objectid)
                    .ValueGeneratedNever()
                    .HasColumnName("objectid");

                entity.Property(e => e.Device).HasColumnName("device");

                entity.Property(e => e.Dt)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("dt")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Engineer).HasColumnName("engineer");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasDefaultValueSql("1");

                entity.HasOne(d => d.DeviceNavigation)
                    .WithMany(p => p.Services)
                    .HasForeignKey(d => d.Device)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_service_device");

                entity.HasOne(d => d.EngineerNavigation)
                    .WithMany(p => p.Services)
                    .HasForeignKey(d => d.Engineer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_service_engineer");
            });

            modelBuilder.Entity<Shift>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("pk_shift");

                entity.ToTable("shift");

                entity.HasIndex(e => e.Person, "idx_shift_person");

                entity.Property(e => e.Objectid)
                    .ValueGeneratedNever()
                    .HasColumnName("objectid");

                entity.Property(e => e.Finishdt)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("finishdt");

                entity.Property(e => e.Person).HasColumnName("person");

                entity.Property(e => e.Startdt)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("startdt")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasDefaultValueSql("1");

                entity.HasOne(d => d.PersonNavigation)
                    .WithMany(p => p.Shifts)
                    .HasForeignKey(d => d.Person)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_shift_person");
            });

            modelBuilder.Entity<Software>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("pk_software");

                entity.ToTable("software");

                entity.HasIndex(e => e.Dssalgorithm, "idx_software_dssalgorithm");

                entity.HasIndex(e => e.Valuealgorithm, "idx_software_valuealgorithm");

                entity.Property(e => e.Objectid)
                    .ValueGeneratedNever()
                    .HasColumnName("objectid");

                entity.Property(e => e.Description)
                    .HasMaxLength(1024)
                    .HasColumnName("description");

                entity.Property(e => e.Dssalgorithm).HasColumnName("dssalgorithm");

                entity.Property(e => e.Releasedt)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("releasedt");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Valuealgorithm).HasColumnName("valuealgorithm");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("version");

                entity.HasOne(d => d.DssalgorithmNavigation)
                    .WithMany(p => p.SoftwareDssalgorithmNavigations)
                    .HasForeignKey(d => d.Dssalgorithm)
                    .HasConstraintName("fk_software_dssalgorithm");

                entity.HasOne(d => d.ValuealgorithmNavigation)
                    .WithMany(p => p.SoftwareValuealgorithmNavigations)
                    .HasForeignKey(d => d.Valuealgorithm)
                    .HasConstraintName("fk_software_valuealgorithm");
            });

            modelBuilder.Entity<Subscription>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("pk_subscription");

                entity.ToTable("subscription");

                entity.HasIndex(e => e.Eventtype, "idx_subscription_eventtype");

                entity.HasIndex(e => e.Person, "idx_subscription_person");

                entity.Property(e => e.Objectid)
                    .ValueGeneratedNever()
                    .HasColumnName("objectid");

                entity.Property(e => e.Channel).HasColumnName("channel");

                entity.Property(e => e.Enabled)
                    .IsRequired()
                    .HasColumnName("enabled")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Eventtype).HasColumnName("eventtype");

                entity.Property(e => e.Person).HasColumnName("person");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasDefaultValueSql("1");

                entity.HasOne(d => d.EventtypeNavigation)
                    .WithMany(p => p.Subscriptions)
                    .HasForeignKey(d => d.Eventtype)
                    .HasConstraintName("fk_subscription_eventtype");

                entity.HasOne(d => d.PersonNavigation)
                    .WithMany(p => p.Subscriptions)
                    .HasForeignKey(d => d.Person)
                    .HasConstraintName("fk_subscription_person");
            });

            modelBuilder.Entity<SubscriptionOrgunit>(entity =>
            {
                entity.HasKey(e => new { e.Objectid, e.Value })
                    .HasName("pk_subscription_orgunit");

                entity.ToTable("subscription_orgunit");

                entity.HasIndex(e => e.Value, "idx_subscription_orgunit_value");

                entity.Property(e => e.Objectid).HasColumnName("objectid");

                entity.Property(e => e.Value).HasColumnName("value");

                entity.HasOne(d => d.Object)
                    .WithMany(p => p.SubscriptionOrgunits)
                    .HasForeignKey(d => d.Objectid)
                    .HasConstraintName("fk_subscription_orgunit_objectid");

                entity.HasOne(d => d.ValueNavigation)
                    .WithMany(p => p.SubscriptionOrgunits)
                    .HasForeignKey(d => d.Value)
                    .HasConstraintName("fk_subscription_orgunit_value");
            });

            modelBuilder.Entity<Telegramidentity>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("pk_telegramidentity");

                entity.ToTable("telegramidentity");

                entity.HasIndex(e => e.Authenticity, "idx_telegramidentity_authenticity");

                entity.Property(e => e.Objectid)
                    .ValueGeneratedNever()
                    .HasColumnName("objectid");

                entity.Property(e => e.Authenticity).HasColumnName("authenticity");

                entity.Property(e => e.Telegramid)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("telegramid");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasDefaultValueSql("1");

                entity.HasOne(d => d.AuthenticityNavigation)
                    .WithMany(p => p.Telegramidentities)
                    .HasForeignKey(d => d.Authenticity)
                    .HasConstraintName("fk_telegramidentity_authenticity");
            });

            modelBuilder.Entity<Terminal>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("pk_terminal");

                entity.ToTable("terminal");

                entity.HasIndex(e => e.Doctoractivitystatus, "idx_terminal_doctoractivitystatus");

                entity.HasIndex(e => e.Orgunit, "idx_terminal_orgunit");

                entity.HasIndex(e => e.Software, "idx_terminal_software");

                entity.HasIndex(e => e.Status, "idx_terminal_status");

                entity.HasIndex(e => e.Sn, "terminal_idx_sn")
                    .IsUnique();

                entity.Property(e => e.Objectid)
                    .ValueGeneratedNever()
                    .HasColumnName("objectid");

                entity.Property(e => e.Comment)
                    .HasMaxLength(1024)
                    .HasColumnName("comment");

                entity.Property(e => e.Doctoractivitystatus).HasColumnName("doctoractivitystatus");

                entity.Property(e => e.Hardwareid)
                    .HasMaxLength(255)
                    .HasColumnName("hardwareid");

                entity.Property(e => e.Orgunit).HasColumnName("orgunit");

                entity.Property(e => e.Sn)
                    .HasMaxLength(255)
                    .HasColumnName("sn");

                entity.Property(e => e.Software).HasColumnName("software");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasDefaultValueSql("1");

                entity.HasOne(d => d.DoctoractivitystatusNavigation)
                    .WithMany(p => p.Terminals)
                    .HasForeignKey(d => d.Doctoractivitystatus)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_terminal_doctoractivitystatus");

                entity.HasOne(d => d.OrgunitNavigation)
                    .WithMany(p => p.Terminals)
                    .HasForeignKey(d => d.Orgunit)
                    .HasConstraintName("fk_terminal_orgunit");

                entity.HasOne(d => d.SoftwareNavigation)
                    .WithMany(p => p.Terminals)
                    .HasForeignKey(d => d.Software)
                    .HasConstraintName("fk_terminal_software");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.Terminals)
                    .HasForeignKey(d => d.Status)
                    .HasConstraintName("fk_terminal_status");
            });

            modelBuilder.Entity<TerminalArtefact>(entity =>
            {
                entity.HasKey(e => new { e.Objectid, e.Value })
                    .HasName("pk_terminal_artefact");

                entity.ToTable("terminal_artefact");

                entity.HasIndex(e => e.Value, "idx_terminal_artefact_value");

                entity.Property(e => e.Objectid).HasColumnName("objectid");

                entity.Property(e => e.Value).HasColumnName("value");

                entity.HasOne(d => d.Object)
                    .WithMany(p => p.TerminalArtefacts)
                    .HasForeignKey(d => d.Objectid)
                    .HasConstraintName("fk_terminal_artefact_objectid");

                entity.HasOne(d => d.ValueNavigation)
                    .WithMany(p => p.TerminalArtefacts)
                    .HasForeignKey(d => d.Value)
                    .HasConstraintName("fk_terminal_artefact_value");
            });

            modelBuilder.Entity<TerminalchildorgunitTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("terminalchildorgunit_table", "pg_temp_7");

                entity.Property(e => e.Objectid).HasColumnName("objectid");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("pk_user");

                entity.ToTable("user");

                entity.Property(e => e.Objectid)
                    .ValueGeneratedNever()
                    .HasColumnName("objectid");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasColumnName("firstname");

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasColumnName("lastname");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("login");

                entity.Property(e => e.Password)
                    .HasMaxLength(64)
                    .HasColumnName("password");

                entity.Property(e => e.Photo)
                    .HasColumnType("oid")
                    .HasColumnName("photo");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasDefaultValueSql("1");

                entity.HasOne(d => d.PhotoNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.Photo)
                    .HasConstraintName("fk_user_photo");
            });

            modelBuilder.Entity<Xchunkstorage>(entity =>
            {
                entity.HasKey(e => new { e.Chunkchainid, e.Chunkindex })
                    .HasName("pk_xchunkstorage");

                entity.ToTable("xchunkstorage");

                entity.Property(e => e.Chunkchainid)
                    .HasMaxLength(64)
                    .HasColumnName("chunkchainid");

                entity.Property(e => e.Chunkindex).HasColumnName("chunkindex");

                entity.Property(e => e.Chunkdata)
                    .HasColumnType("oid")
                    .HasColumnName("chunkdata");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasDefaultValueSql("date_trunc('day'::text, clock_timestamp())");
            });

            modelBuilder.Entity<Xconstraintschecksum>(entity =>
            {
                entity.HasKey(e => e.Constraintname)
                    .HasName("pk_xconstraintschecksum");

                entity.ToTable("xconstraintschecksum");

                entity.Property(e => e.Constraintname)
                    .HasMaxLength(255)
                    .HasColumnName("constraintname");

                entity.Property(e => e.Constraintchecksum)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("constraintchecksum");
            });

            modelBuilder.Entity<Xloblinkcount>(entity =>
            {
                entity.HasKey(e => e.Lobid)
                    .HasName("pk_xloblinkcount");

                entity.ToTable("xloblinkcount");

                entity.Property(e => e.Lobid)
                    .HasColumnType("oid")
                    .ValueGeneratedNever()
                    .HasColumnName("lobid");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasDefaultValueSql("clock_timestamp()");

                entity.Property(e => e.Linkcount).HasColumnName("linkcount");

                entity.Property(e => e.Updated)
                    .HasColumnName("updated")
                    .HasDefaultValueSql("clock_timestamp()");
            });

            modelBuilder.Entity<Xsessionvar>(entity =>
            {
                entity.HasKey(e => new { e.Backendpid, e.Variablename })
                    .HasName("pk_xsessionvars");

                entity.ToTable("xsessionvars");

                entity.Property(e => e.Backendpid).HasColumnName("backendpid");

                entity.Property(e => e.Variablename).HasColumnName("variablename");

                entity.Property(e => e.Variablevalueint).HasColumnName("variablevalueint");

                entity.Property(e => e.Variablevaluetext).HasColumnName("variablevaluetext");
            });

            modelBuilder.Entity<Xversioninfostorage>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("xversioninfostorage");

                entity.HasIndex(e => new { e.Module, e.Version }, "ux_xversioninfostorage_mod_ver")
                    .IsUnique();

                entity.Property(e => e.Appliedat).HasColumnName("appliedat");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.Module)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("module");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("version");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
