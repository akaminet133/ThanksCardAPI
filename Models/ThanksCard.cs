using System;
using System.Collections.Generic;

namespace ThanksCardAPI.Models
{
    public class ThanksCard
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public long Fav { get; set; }
        public DateTime CreatedDateTime { get; set; }

        //���M�ҏ�� : ����1
        public long FromId { get; set; }
        public virtual User From { get; set; }
        //��M�ҏ��
        public long ToId { get; set; }
        public virtual User To { get; set; }
        //�J�e�S���[
        public long CategoryId { get; set; }
        public virtual Category Category{ get; set; }
    }
}
