using System;
using System.Collections.Generic;

#nullable disable

namespace Croc.Medkiosk.TelegramBot.Data.Models
{
    public partial class Person
    {
        public Person()
        {
            ActionrequestCreatorNavigations = new HashSet<Actionrequest>();
            ActionrequestResponsiblepersonNavigations = new HashSet<Actionrequest>();
            Answerables = new HashSet<Answerable>();
            Authenticities = new HashSet<Authenticity>();
            BlockCreatorNavigations = new HashSet<Block>();
            BlockPatientNavigations = new HashSet<Block>();
            BlockUnblockedpersonNavigations = new HashSet<Block>();
            Conclusions = new HashSet<Conclusion>();
            Conversations = new HashSet<Conversation>();
            Doctoractivitystatuses = new HashSet<Doctoractivitystatus>();
            Documents = new HashSet<Document>();
            ExaminationEmployeeNavigations = new HashSet<Examination>();
            ExaminationPatientNavigations = new HashSet<Examination>();
            Logmessages = new HashSet<Logmessage>();
            Orgunits = new HashSet<Orgunit>();
            PersonArtefacts = new HashSet<PersonArtefact>();
            PersonPgroups = new HashSet<PersonPgroup>();
            PersonRoles = new HashSet<PersonRole>();
            Personunblockrequests = new HashSet<Personunblockrequest>();
            Services = new HashSet<Service>();
            Shifts = new HashSet<Shift>();
            Subscriptions = new HashSet<Subscription>();
        }

        public Guid Objectid { get; set; }
        public long Ts { get; set; }
        public string Fullname { get; set; }
        public DateTime? Birthday { get; set; }
        public int? Number { get; set; }
        public string Profession { get; set; }
        public Guid? Orgunit { get; set; }
        public bool? Ismale { get; set; }
        public int? Flags { get; set; }

        public virtual Orgunit OrgunitNavigation { get; set; }
        public virtual ICollection<Actionrequest> ActionrequestCreatorNavigations { get; set; }
        public virtual ICollection<Actionrequest> ActionrequestResponsiblepersonNavigations { get; set; }
        public virtual ICollection<Answerable> Answerables { get; set; }
        public virtual ICollection<Authenticity> Authenticities { get; set; }
        public virtual ICollection<Block> BlockCreatorNavigations { get; set; }
        public virtual ICollection<Block> BlockPatientNavigations { get; set; }
        public virtual ICollection<Block> BlockUnblockedpersonNavigations { get; set; }
        public virtual ICollection<Conclusion> Conclusions { get; set; }
        public virtual ICollection<Conversation> Conversations { get; set; }
        public virtual ICollection<Doctoractivitystatus> Doctoractivitystatuses { get; set; }
        public virtual ICollection<Document> Documents { get; set; }
        public virtual ICollection<Examination> ExaminationEmployeeNavigations { get; set; }
        public virtual ICollection<Examination> ExaminationPatientNavigations { get; set; }
        public virtual ICollection<Logmessage> Logmessages { get; set; }
        public virtual ICollection<Orgunit> Orgunits { get; set; }
        public virtual ICollection<PersonArtefact> PersonArtefacts { get; set; }
        public virtual ICollection<PersonPgroup> PersonPgroups { get; set; }
        public virtual ICollection<PersonRole> PersonRoles { get; set; }
        public virtual ICollection<Personunblockrequest> Personunblockrequests { get; set; }
        public virtual ICollection<Service> Services { get; set; }
        public virtual ICollection<Shift> Shifts { get; set; }
        public virtual ICollection<Subscription> Subscriptions { get; set; }
    }
}
