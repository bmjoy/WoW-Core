// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: bgs/low/pb/client/entity_types.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Bgs.Protocol {

  /// <summary>Holder for reflection information generated from bgs/low/pb/client/entity_types.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class EntityTypesReflection {

    #region Descriptor
    /// <summary>File descriptor for bgs/low/pb/client/entity_types.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EntityTypesReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRiZ3MvbG93L3BiL2NsaWVudC9lbnRpdHlfdHlwZXMucHJvdG8SDGJncy5w",
            "cm90b2NvbBo3YmdzL2xvdy9wYi9jbGllbnQvZ2xvYmFsX2V4dGVuc2lvbnMv",
            "ZmllbGRfb3B0aW9ucy5wcm90byIlCghFbnRpdHlJZBIMCgRoaWdoGAEgASgG",
            "EgsKA2xvdxgCIAEoBiJnCghJZGVudGl0eRIqCgphY2NvdW50X2lkGAEgASgL",
            "MhYuYmdzLnByb3RvY29sLkVudGl0eUlkEi8KD2dhbWVfYWNjb3VudF9pZBgC",
            "IAEoCzIWLmJncy5wcm90b2NvbC5FbnRpdHlJZCKjAQoLQWNjb3VudEluZm8S",
            "FAoMYWNjb3VudF9wYWlkGAEgASgIEhIKCmNvdW50cnlfaWQYAiABKAcSEgoK",
            "YmF0dGxlX3RhZxgDIAEoCRIVCg1tYW51YWxfcmV2aWV3GAQgASgIEigKCGlk",
            "ZW50aXR5GAUgASgLMhYuYmdzLnByb3RvY29sLklkZW50aXR5EhUKDWFjY291",
            "bnRfbXV0ZWQYBiABKAhCHgoNYm5ldC5wcm90b2NvbEILRW50aXR5UHJvdG9I",
            "AmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Bgs.Protocol.FieldOptionsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Bgs.Protocol.EntityId), global::Bgs.Protocol.EntityId.Parser, new[]{ "High", "Low" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Bgs.Protocol.Identity), global::Bgs.Protocol.Identity.Parser, new[]{ "AccountId", "GameAccountId" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Bgs.Protocol.AccountInfo), global::Bgs.Protocol.AccountInfo.Parser, new[]{ "AccountPaid", "CountryId", "BattleTag", "ManualReview", "Identity", "AccountMuted" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class EntityId : pb::IMessage<EntityId> {
    private static readonly pb::MessageParser<EntityId> _parser = new pb::MessageParser<EntityId>(() => new EntityId());
    public static pb::MessageParser<EntityId> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Bgs.Protocol.EntityTypesReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public EntityId() {
      OnConstruction();
    }

    partial void OnConstruction();

    public EntityId(EntityId other) : this() {
      high_ = other.high_;
      low_ = other.low_;
    }

    public EntityId Clone() {
      return new EntityId(this);
    }

    /// <summary>Field number for the "high" field.</summary>
    public const int HighFieldNumber = 1;
    private ulong high_;
    public ulong High {
      get { return high_; }
      set {
        high_ = value;
      }
    }

    /// <summary>Field number for the "low" field.</summary>
    public const int LowFieldNumber = 2;
    private ulong low_;
    public ulong Low {
      get { return low_; }
      set {
        low_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as EntityId);
    }

    public bool Equals(EntityId other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (High != other.High) return false;
      if (Low != other.Low) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (High != 0UL) hash ^= High.GetHashCode();
      if (Low != 0UL) hash ^= Low.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (High != 0UL) {
        output.WriteRawTag(9);
        output.WriteFixed64(High);
      }
      if (Low != 0UL) {
        output.WriteRawTag(17);
        output.WriteFixed64(Low);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (High != 0UL) {
        size += 1 + 8;
      }
      if (Low != 0UL) {
        size += 1 + 8;
      }
      return size;
    }

    public void MergeFrom(EntityId other) {
      if (other == null) {
        return;
      }
      if (other.High != 0UL) {
        High = other.High;
      }
      if (other.Low != 0UL) {
        Low = other.Low;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 9: {
            High = input.ReadFixed64();
            break;
          }
          case 17: {
            Low = input.ReadFixed64();
            break;
          }
        }
      }
    }

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Identity : pb::IMessage<Identity> {
    private static readonly pb::MessageParser<Identity> _parser = new pb::MessageParser<Identity>(() => new Identity());
    public static pb::MessageParser<Identity> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Bgs.Protocol.EntityTypesReflection.Descriptor.MessageTypes[1]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public Identity() {
      OnConstruction();
    }

    partial void OnConstruction();

    public Identity(Identity other) : this() {
      AccountId = other.accountId_ != null ? other.AccountId.Clone() : null;
      GameAccountId = other.gameAccountId_ != null ? other.GameAccountId.Clone() : null;
    }

    public Identity Clone() {
      return new Identity(this);
    }

    /// <summary>Field number for the "account_id" field.</summary>
    public const int AccountIdFieldNumber = 1;
    private global::Bgs.Protocol.EntityId accountId_;
    public global::Bgs.Protocol.EntityId AccountId {
      get { return accountId_; }
      set {
        accountId_ = value;
      }
    }

    /// <summary>Field number for the "game_account_id" field.</summary>
    public const int GameAccountIdFieldNumber = 2;
    private global::Bgs.Protocol.EntityId gameAccountId_;
    public global::Bgs.Protocol.EntityId GameAccountId {
      get { return gameAccountId_; }
      set {
        gameAccountId_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as Identity);
    }

    public bool Equals(Identity other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(AccountId, other.AccountId)) return false;
      if (!object.Equals(GameAccountId, other.GameAccountId)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (accountId_ != null) hash ^= AccountId.GetHashCode();
      if (gameAccountId_ != null) hash ^= GameAccountId.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (accountId_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(AccountId);
      }
      if (gameAccountId_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(GameAccountId);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (accountId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AccountId);
      }
      if (gameAccountId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GameAccountId);
      }
      return size;
    }

    public void MergeFrom(Identity other) {
      if (other == null) {
        return;
      }
      if (other.accountId_ != null) {
        if (accountId_ == null) {
          accountId_ = new global::Bgs.Protocol.EntityId();
        }
        AccountId.MergeFrom(other.AccountId);
      }
      if (other.gameAccountId_ != null) {
        if (gameAccountId_ == null) {
          gameAccountId_ = new global::Bgs.Protocol.EntityId();
        }
        GameAccountId.MergeFrom(other.GameAccountId);
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            if (accountId_ == null) {
              accountId_ = new global::Bgs.Protocol.EntityId();
            }
            input.ReadMessage(accountId_);
            break;
          }
          case 18: {
            if (gameAccountId_ == null) {
              gameAccountId_ = new global::Bgs.Protocol.EntityId();
            }
            input.ReadMessage(gameAccountId_);
            break;
          }
        }
      }
    }

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class AccountInfo : pb::IMessage<AccountInfo> {
    private static readonly pb::MessageParser<AccountInfo> _parser = new pb::MessageParser<AccountInfo>(() => new AccountInfo());
    public static pb::MessageParser<AccountInfo> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Bgs.Protocol.EntityTypesReflection.Descriptor.MessageTypes[2]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public AccountInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    public AccountInfo(AccountInfo other) : this() {
      accountPaid_ = other.accountPaid_;
      countryId_ = other.countryId_;
      battleTag_ = other.battleTag_;
      manualReview_ = other.manualReview_;
      Identity = other.identity_ != null ? other.Identity.Clone() : null;
      accountMuted_ = other.accountMuted_;
    }

    public AccountInfo Clone() {
      return new AccountInfo(this);
    }

    /// <summary>Field number for the "account_paid" field.</summary>
    public const int AccountPaidFieldNumber = 1;
    private bool accountPaid_;
    public bool AccountPaid {
      get { return accountPaid_; }
      set {
        accountPaid_ = value;
      }
    }

    /// <summary>Field number for the "country_id" field.</summary>
    public const int CountryIdFieldNumber = 2;
    private uint countryId_;
    public uint CountryId {
      get { return countryId_; }
      set {
        countryId_ = value;
      }
    }

    /// <summary>Field number for the "battle_tag" field.</summary>
    public const int BattleTagFieldNumber = 3;
    private string battleTag_ = "";
    public string BattleTag {
      get { return battleTag_; }
      set {
        battleTag_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "manual_review" field.</summary>
    public const int ManualReviewFieldNumber = 4;
    private bool manualReview_;
    public bool ManualReview {
      get { return manualReview_; }
      set {
        manualReview_ = value;
      }
    }

    /// <summary>Field number for the "identity" field.</summary>
    public const int IdentityFieldNumber = 5;
    private global::Bgs.Protocol.Identity identity_;
    public global::Bgs.Protocol.Identity Identity {
      get { return identity_; }
      set {
        identity_ = value;
      }
    }

    /// <summary>Field number for the "account_muted" field.</summary>
    public const int AccountMutedFieldNumber = 6;
    private bool accountMuted_;
    public bool AccountMuted {
      get { return accountMuted_; }
      set {
        accountMuted_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as AccountInfo);
    }

    public bool Equals(AccountInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AccountPaid != other.AccountPaid) return false;
      if (CountryId != other.CountryId) return false;
      if (BattleTag != other.BattleTag) return false;
      if (ManualReview != other.ManualReview) return false;
      if (!object.Equals(Identity, other.Identity)) return false;
      if (AccountMuted != other.AccountMuted) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (AccountPaid != false) hash ^= AccountPaid.GetHashCode();
      if (CountryId != 0) hash ^= CountryId.GetHashCode();
      if (BattleTag.Length != 0) hash ^= BattleTag.GetHashCode();
      if (ManualReview != false) hash ^= ManualReview.GetHashCode();
      if (identity_ != null) hash ^= Identity.GetHashCode();
      if (AccountMuted != false) hash ^= AccountMuted.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (AccountPaid != false) {
        output.WriteRawTag(8);
        output.WriteBool(AccountPaid);
      }
      if (CountryId != 0) {
        output.WriteRawTag(21);
        output.WriteFixed32(CountryId);
      }
      if (BattleTag.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(BattleTag);
      }
      if (ManualReview != false) {
        output.WriteRawTag(32);
        output.WriteBool(ManualReview);
      }
      if (identity_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(Identity);
      }
      if (AccountMuted != false) {
        output.WriteRawTag(48);
        output.WriteBool(AccountMuted);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (AccountPaid != false) {
        size += 1 + 1;
      }
      if (CountryId != 0) {
        size += 1 + 4;
      }
      if (BattleTag.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(BattleTag);
      }
      if (ManualReview != false) {
        size += 1 + 1;
      }
      if (identity_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Identity);
      }
      if (AccountMuted != false) {
        size += 1 + 1;
      }
      return size;
    }

    public void MergeFrom(AccountInfo other) {
      if (other == null) {
        return;
      }
      if (other.AccountPaid != false) {
        AccountPaid = other.AccountPaid;
      }
      if (other.CountryId != 0) {
        CountryId = other.CountryId;
      }
      if (other.BattleTag.Length != 0) {
        BattleTag = other.BattleTag;
      }
      if (other.ManualReview != false) {
        ManualReview = other.ManualReview;
      }
      if (other.identity_ != null) {
        if (identity_ == null) {
          identity_ = new global::Bgs.Protocol.Identity();
        }
        Identity.MergeFrom(other.Identity);
      }
      if (other.AccountMuted != false) {
        AccountMuted = other.AccountMuted;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            AccountPaid = input.ReadBool();
            break;
          }
          case 21: {
            CountryId = input.ReadFixed32();
            break;
          }
          case 26: {
            BattleTag = input.ReadString();
            break;
          }
          case 32: {
            ManualReview = input.ReadBool();
            break;
          }
          case 42: {
            if (identity_ == null) {
              identity_ = new global::Bgs.Protocol.Identity();
            }
            input.ReadMessage(identity_);
            break;
          }
          case 48: {
            AccountMuted = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
