using FreeSql.DataAnnotations;

using System.Text.RegularExpressions;

namespace FaceMan.Tools.Models.CodeGenerator
{
    /// <summary>
    /// 实体列表类
    /// </summary>
    [Table(Name = "Entity")]
    public class Entity
    {
        /// <summary>
        /// 主键
        /// </summary>
        [Column(IsIdentity = true, IsPrimary = true)]
        public int Id { get; set; }
        /// <summary>
        /// 实体名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 字段列表
        /// </summary>
        [Navigate(nameof(Field.EntityId))]
        public List<Field> Fields { get; set; }
        /// <summary>
        /// 实体描述
        /// </summary>
        public string Description { get; set; }

    }

    /// <summary>
    /// 字段类
    /// </summary>
    [Table(Name = "Field")]
    public class Field
    {
        /// <summary>
        /// 主键
        /// </summary>
        [Column(IsIdentity = true, IsPrimary = true)]
        public int Id { get; set; }
        /// <summary>
        /// 父Id
        /// </summary>
        public int EntityId { get; set; }
        /// <summary>
        /// 字段名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 字段类型
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// 字段长度
        /// </summary>
        public string Length { get; set; }
        /// <summary>
        /// 字段描述
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 是否主键
        /// </summary>
        public bool IsPrimaryKey { get; set; }
        /// <summary>
        /// 是否可空
        /// </summary>
        public bool IsNullable { get; set; }
        /// <summary>
        /// 是否自增
        /// </summary>
        public bool IsIdentity { get; set; }
        /// <summary>
        /// 小数位数
        /// </summary>
        public int Precision { get; set; }
        /// <summary>
        /// 导航属性
        /// </summary>
        [Navigate(nameof(EntityId))]
        public Entity Entity { get; set; }
    }
}
