// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: bgs/low/pb/client/role_types.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Bgs.Protocol {

  /// <summary>Holder for reflection information generated from bgs/low/pb/client/role_types.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class RoleTypesReflection {

    #region Descriptor
    /// <summary>File descriptor for bgs/low/pb/client/role_types.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RoleTypesReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJiZ3MvbG93L3BiL2NsaWVudC9yb2xlX3R5cGVzLnByb3RvEgxiZ3MucHJv",
            "dG9jb2waJ2Jncy9sb3cvcGIvY2xpZW50L2F0dHJpYnV0ZV90eXBlcy5wcm90",
            "byLuAQoEUm9sZRIKCgJpZBgBIAEoDRIMCgRuYW1lGAIgASgJEhEKCXByaXZp",
            "bGVnZRgDIAMoCRIbCg9hc3NpZ25hYmxlX3JvbGUYBCADKA1CAhABEhAKCHJl",
            "cXVpcmVkGAUgASgIEg4KBnVuaXF1ZRgGIAEoCBIXCg9yZWxlZ2F0aW9uX3Jv",
            "bGUYByABKA0SKgoJYXR0cmlidXRlGAggAygLMhcuYmdzLnByb3RvY29sLkF0",
            "dHJpYnV0ZRIZCg1raWNrYWJsZV9yb2xlGAkgAygNQgIQARIaCg5yZW1vdmFi",
            "bGVfcm9sZRgKIAMoDUICEAFCAkgCYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Bgs.Protocol.AttributeTypesReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Bgs.Protocol.Role), global::Bgs.Protocol.Role.Parser, new[]{ "Id", "Name", "Privilege", "AssignableRole", "Required", "Unique", "RelegationRole", "Attribute", "KickableRole", "RemovableRole" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Role : pb::IMessage<Role> {
    private static readonly pb::MessageParser<Role> _parser = new pb::MessageParser<Role>(() => new Role());
    public static pb::MessageParser<Role> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Bgs.Protocol.RoleTypesReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public Role() {
      OnConstruction();
    }

    partial void OnConstruction();

    public Role(Role other) : this() {
      id_ = other.id_;
      name_ = other.name_;
      privilege_ = other.privilege_.Clone();
      assignableRole_ = other.assignableRole_.Clone();
      required_ = other.required_;
      unique_ = other.unique_;
      relegationRole_ = other.relegationRole_;
      attribute_ = other.attribute_.Clone();
      kickableRole_ = other.kickableRole_.Clone();
      removableRole_ = other.removableRole_.Clone();
    }

    public Role Clone() {
      return new Role(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private uint id_;
    public uint Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 2;
    private string name_ = "";
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "privilege" field.</summary>
    public const int PrivilegeFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _repeated_privilege_codec
        = pb::FieldCodec.ForString(26);
    private readonly pbc::RepeatedField<string> privilege_ = new pbc::RepeatedField<string>();
    public pbc::RepeatedField<string> Privilege {
      get { return privilege_; }
    }

    /// <summary>Field number for the "assignable_role" field.</summary>
    public const int AssignableRoleFieldNumber = 4;
    private static readonly pb::FieldCodec<uint> _repeated_assignableRole_codec
        = pb::FieldCodec.ForUInt32(34);
    private readonly pbc::RepeatedField<uint> assignableRole_ = new pbc::RepeatedField<uint>();
    public pbc::RepeatedField<uint> AssignableRole {
      get { return assignableRole_; }
    }

    /// <summary>Field number for the "required" field.</summary>
    public const int RequiredFieldNumber = 5;
    private bool required_;
    public bool Required {
      get { return required_; }
      set {
        required_ = value;
      }
    }

    /// <summary>Field number for the "unique" field.</summary>
    public const int UniqueFieldNumber = 6;
    private bool unique_;
    public bool Unique {
      get { return unique_; }
      set {
        unique_ = value;
      }
    }

    /// <summary>Field number for the "relegation_role" field.</summary>
    public const int RelegationRoleFieldNumber = 7;
    private uint relegationRole_;
    public uint RelegationRole {
      get { return relegationRole_; }
      set {
        relegationRole_ = value;
      }
    }

    /// <summary>Field number for the "attribute" field.</summary>
    public const int AttributeFieldNumber = 8;
    private static readonly pb::FieldCodec<global::Bgs.Protocol.Attribute> _repeated_attribute_codec
        = pb::FieldCodec.ForMessage(66, global::Bgs.Protocol.Attribute.Parser);
    private readonly pbc::RepeatedField<global::Bgs.Protocol.Attribute> attribute_ = new pbc::RepeatedField<global::Bgs.Protocol.Attribute>();
    public pbc::RepeatedField<global::Bgs.Protocol.Attribute> Attribute {
      get { return attribute_; }
    }

    /// <summary>Field number for the "kickable_role" field.</summary>
    public const int KickableRoleFieldNumber = 9;
    private static readonly pb::FieldCodec<uint> _repeated_kickableRole_codec
        = pb::FieldCodec.ForUInt32(74);
    private readonly pbc::RepeatedField<uint> kickableRole_ = new pbc::RepeatedField<uint>();
    public pbc::RepeatedField<uint> KickableRole {
      get { return kickableRole_; }
    }

    /// <summary>Field number for the "removable_role" field.</summary>
    public const int RemovableRoleFieldNumber = 10;
    private static readonly pb::FieldCodec<uint> _repeated_removableRole_codec
        = pb::FieldCodec.ForUInt32(82);
    private readonly pbc::RepeatedField<uint> removableRole_ = new pbc::RepeatedField<uint>();
    public pbc::RepeatedField<uint> RemovableRole {
      get { return removableRole_; }
    }

    public override bool Equals(object other) {
      return Equals(other as Role);
    }

    public bool Equals(Role other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Name != other.Name) return false;
      if(!privilege_.Equals(other.privilege_)) return false;
      if(!assignableRole_.Equals(other.assignableRole_)) return false;
      if (Required != other.Required) return false;
      if (Unique != other.Unique) return false;
      if (RelegationRole != other.RelegationRole) return false;
      if(!attribute_.Equals(other.attribute_)) return false;
      if(!kickableRole_.Equals(other.kickableRole_)) return false;
      if(!removableRole_.Equals(other.removableRole_)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      hash ^= privilege_.GetHashCode();
      hash ^= assignableRole_.GetHashCode();
      if (Required != false) hash ^= Required.GetHashCode();
      if (Unique != false) hash ^= Unique.GetHashCode();
      if (RelegationRole != 0) hash ^= RelegationRole.GetHashCode();
      hash ^= attribute_.GetHashCode();
      hash ^= kickableRole_.GetHashCode();
      hash ^= removableRole_.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Id);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      privilege_.WriteTo(output, _repeated_privilege_codec);
      assignableRole_.WriteTo(output, _repeated_assignableRole_codec);
      if (Required != false) {
        output.WriteRawTag(40);
        output.WriteBool(Required);
      }
      if (Unique != false) {
        output.WriteRawTag(48);
        output.WriteBool(Unique);
      }
      if (RelegationRole != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(RelegationRole);
      }
      attribute_.WriteTo(output, _repeated_attribute_codec);
      kickableRole_.WriteTo(output, _repeated_kickableRole_codec);
      removableRole_.WriteTo(output, _repeated_removableRole_codec);
    }

    public int CalculateSize() {
      int size = 0;
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Id);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      size += privilege_.CalculateSize(_repeated_privilege_codec);
      size += assignableRole_.CalculateSize(_repeated_assignableRole_codec);
      if (Required != false) {
        size += 1 + 1;
      }
      if (Unique != false) {
        size += 1 + 1;
      }
      if (RelegationRole != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RelegationRole);
      }
      size += attribute_.CalculateSize(_repeated_attribute_codec);
      size += kickableRole_.CalculateSize(_repeated_kickableRole_codec);
      size += removableRole_.CalculateSize(_repeated_removableRole_codec);
      return size;
    }

    public void MergeFrom(Role other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      privilege_.Add(other.privilege_);
      assignableRole_.Add(other.assignableRole_);
      if (other.Required != false) {
        Required = other.Required;
      }
      if (other.Unique != false) {
        Unique = other.Unique;
      }
      if (other.RelegationRole != 0) {
        RelegationRole = other.RelegationRole;
      }
      attribute_.Add(other.attribute_);
      kickableRole_.Add(other.kickableRole_);
      removableRole_.Add(other.removableRole_);
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Id = input.ReadUInt32();
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 26: {
            privilege_.AddEntriesFrom(input, _repeated_privilege_codec);
            break;
          }
          case 34:
          case 32: {
            assignableRole_.AddEntriesFrom(input, _repeated_assignableRole_codec);
            break;
          }
          case 40: {
            Required = input.ReadBool();
            break;
          }
          case 48: {
            Unique = input.ReadBool();
            break;
          }
          case 56: {
            RelegationRole = input.ReadUInt32();
            break;
          }
          case 66: {
            attribute_.AddEntriesFrom(input, _repeated_attribute_codec);
            break;
          }
          case 74:
          case 72: {
            kickableRole_.AddEntriesFrom(input, _repeated_kickableRole_codec);
            break;
          }
          case 82:
          case 80: {
            removableRole_.AddEntriesFrom(input, _repeated_removableRole_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
