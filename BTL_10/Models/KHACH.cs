﻿namespace BTL_10.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHACH")]
    public partial class KHACH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHACH()
        {
            DANGKies = new HashSet<DANGKY>();
        }
        //xét điều kiện cho mã khách
        [Key]
        [StringLength(10)]
        [DisplayName("Mã khách")]
        public string MAKHACH { get; set; }

        //xét điều kiện cho họ tên khách
        [DisplayName("Họ và tên ")]
        [Required(ErrorMessage = "Không được để trống !")]
        [StringLength(100)]
        public string TENKHACH { get; set; }

        //xét điều kiện giới tính
        [DisplayName("Giới tính")]
        public bool? PHAI { get; set; }

        //xét điều kiện cho địa chỉ
        [DisplayName("Địa chỉ")]
        [StringLength(100)]
        [Required(ErrorMessage = "Không được để trống !")]
        public string DIACHI { get; set; }

        //xét điều kiện cho chứng minh thư
        [Column(TypeName = "numeric")]
        [DisplayName("Số CMND")]
        [Required(ErrorMessage = "Không được để trống !")]
        public decimal? CMND { get; set; }

        //xét điều kiện cho điện thoại
        [Column(TypeName = "numeric")]
        [DisplayName("Số điện thoại")]
        [Required(ErrorMessage = "Không được để trống !")]
        public decimal? SDT { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DANGKY> DANGKies { get; set; }
    }
}
