// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: bgs/low/pb/client/rpc_config.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Bgs.Protocol.Config {

  /// <summary>Holder for reflection information generated from bgs/low/pb/client/rpc_config.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class RpcConfigReflection {

    #region Descriptor
    /// <summary>File descriptor for bgs/low/pb/client/rpc_config.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RpcConfigReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJiZ3MvbG93L3BiL2NsaWVudC9ycGNfY29uZmlnLnByb3RvEhNiZ3MucHJv",
            "dG9jb2wuY29uZmlnIvwCCg9SUENNZXRob2RDb25maWcSGAoMc2VydmljZV9u",
            "YW1lGAEgASgJQgIYARIXCgttZXRob2RfbmFtZRgCIAEoCUICGAESFwoPZml4",
            "ZWRfY2FsbF9jb3N0GAMgASgNEhkKEWZpeGVkX3BhY2tldF9zaXplGAQgASgN",
            "EhsKE3ZhcmlhYmxlX211bHRpcGxpZXIYBSABKAISEgoKbXVsdGlwbGllchgG",
            "IAEoAhIYChByYXRlX2xpbWl0X2NvdW50GAcgASgNEhoKEnJhdGVfbGltaXRf",
            "c2Vjb25kcxgIIAEoDRIXCg9tYXhfcGFja2V0X3NpemUYCSABKA0SGAoQbWF4",
            "X2VuY29kZWRfc2l6ZRgKIAEoDRIPCgd0aW1lb3V0GAsgASgCEhMKC2NhcF9i",
            "YWxhbmNlGAwgASgNEhkKEWluY29tZV9wZXJfc2Vjb25kGA0gASgCEhQKDHNl",
            "cnZpY2VfaGFzaBgOIAEoDRIRCgltZXRob2RfaWQYDyABKA0ipwEKDlJQQ01l",
            "dGVyQ29uZmlnEjQKBm1ldGhvZBgBIAMoCzIkLmJncy5wcm90b2NvbC5jb25m",
            "aWcuUlBDTWV0aG9kQ29uZmlnEhkKEWluY29tZV9wZXJfc2Vjb25kGAIgASgN",
            "EhcKD2luaXRpYWxfYmFsYW5jZRgDIAEoDRITCgtjYXBfYmFsYW5jZRgEIAEo",
            "DRIWCg5zdGFydHVwX3BlcmlvZBgFIAEoAiJJCg1Qcm90b2NvbEFsaWFzEhsK",
            "E3NlcnZlcl9zZXJ2aWNlX25hbWUYASABKAkSGwoTY2xpZW50X3NlcnZpY2Vf",
            "bmFtZRgCIAEoCSJMCg5TZXJ2aWNlQWxpYXNlcxI6Cg5wcm90b2NvbF9hbGlh",
            "cxgBIAMoCzIiLmJncy5wcm90b2NvbC5jb25maWcuUHJvdG9jb2xBbGlhc0IC",
            "SAJiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Bgs.Protocol.Config.RPCMethodConfig), global::Bgs.Protocol.Config.RPCMethodConfig.Parser, new[]{ "ServiceName", "MethodName", "FixedCallCost", "FixedPacketSize", "VariableMultiplier", "Multiplier", "RateLimitCount", "RateLimitSeconds", "MaxPacketSize", "MaxEncodedSize", "Timeout", "CapBalance", "IncomePerSecond", "ServiceHash", "MethodId" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Bgs.Protocol.Config.RPCMeterConfig), global::Bgs.Protocol.Config.RPCMeterConfig.Parser, new[]{ "Method", "IncomePerSecond", "InitialBalance", "CapBalance", "StartupPeriod" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Bgs.Protocol.Config.ProtocolAlias), global::Bgs.Protocol.Config.ProtocolAlias.Parser, new[]{ "ServerServiceName", "ClientServiceName" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Bgs.Protocol.Config.ServiceAliases), global::Bgs.Protocol.Config.ServiceAliases.Parser, new[]{ "ProtocolAlias" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class RPCMethodConfig : pb::IMessage<RPCMethodConfig> {
    private static readonly pb::MessageParser<RPCMethodConfig> _parser = new pb::MessageParser<RPCMethodConfig>(() => new RPCMethodConfig());
    public static pb::MessageParser<RPCMethodConfig> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Bgs.Protocol.Config.RpcConfigReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public RPCMethodConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    public RPCMethodConfig(RPCMethodConfig other) : this() {
      serviceName_ = other.serviceName_;
      methodName_ = other.methodName_;
      fixedCallCost_ = other.fixedCallCost_;
      fixedPacketSize_ = other.fixedPacketSize_;
      variableMultiplier_ = other.variableMultiplier_;
      multiplier_ = other.multiplier_;
      rateLimitCount_ = other.rateLimitCount_;
      rateLimitSeconds_ = other.rateLimitSeconds_;
      maxPacketSize_ = other.maxPacketSize_;
      maxEncodedSize_ = other.maxEncodedSize_;
      timeout_ = other.timeout_;
      capBalance_ = other.capBalance_;
      incomePerSecond_ = other.incomePerSecond_;
      serviceHash_ = other.serviceHash_;
      methodId_ = other.methodId_;
    }

    public RPCMethodConfig Clone() {
      return new RPCMethodConfig(this);
    }

    /// <summary>Field number for the "service_name" field.</summary>
    public const int ServiceNameFieldNumber = 1;
    private string serviceName_ = "";
    [global::System.ObsoleteAttribute()]
    public string ServiceName {
      get { return serviceName_; }
      set {
        serviceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "method_name" field.</summary>
    public const int MethodNameFieldNumber = 2;
    private string methodName_ = "";
    [global::System.ObsoleteAttribute()]
    public string MethodName {
      get { return methodName_; }
      set {
        methodName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "fixed_call_cost" field.</summary>
    public const int FixedCallCostFieldNumber = 3;
    private uint fixedCallCost_;
    public uint FixedCallCost {
      get { return fixedCallCost_; }
      set {
        fixedCallCost_ = value;
      }
    }

    /// <summary>Field number for the "fixed_packet_size" field.</summary>
    public const int FixedPacketSizeFieldNumber = 4;
    private uint fixedPacketSize_;
    public uint FixedPacketSize {
      get { return fixedPacketSize_; }
      set {
        fixedPacketSize_ = value;
      }
    }

    /// <summary>Field number for the "variable_multiplier" field.</summary>
    public const int VariableMultiplierFieldNumber = 5;
    private float variableMultiplier_;
    public float VariableMultiplier {
      get { return variableMultiplier_; }
      set {
        variableMultiplier_ = value;
      }
    }

    /// <summary>Field number for the "multiplier" field.</summary>
    public const int MultiplierFieldNumber = 6;
    private float multiplier_;
    public float Multiplier {
      get { return multiplier_; }
      set {
        multiplier_ = value;
      }
    }

    /// <summary>Field number for the "rate_limit_count" field.</summary>
    public const int RateLimitCountFieldNumber = 7;
    private uint rateLimitCount_;
    public uint RateLimitCount {
      get { return rateLimitCount_; }
      set {
        rateLimitCount_ = value;
      }
    }

    /// <summary>Field number for the "rate_limit_seconds" field.</summary>
    public const int RateLimitSecondsFieldNumber = 8;
    private uint rateLimitSeconds_;
    public uint RateLimitSeconds {
      get { return rateLimitSeconds_; }
      set {
        rateLimitSeconds_ = value;
      }
    }

    /// <summary>Field number for the "max_packet_size" field.</summary>
    public const int MaxPacketSizeFieldNumber = 9;
    private uint maxPacketSize_;
    public uint MaxPacketSize {
      get { return maxPacketSize_; }
      set {
        maxPacketSize_ = value;
      }
    }

    /// <summary>Field number for the "max_encoded_size" field.</summary>
    public const int MaxEncodedSizeFieldNumber = 10;
    private uint maxEncodedSize_;
    public uint MaxEncodedSize {
      get { return maxEncodedSize_; }
      set {
        maxEncodedSize_ = value;
      }
    }

    /// <summary>Field number for the "timeout" field.</summary>
    public const int TimeoutFieldNumber = 11;
    private float timeout_;
    public float Timeout {
      get { return timeout_; }
      set {
        timeout_ = value;
      }
    }

    /// <summary>Field number for the "cap_balance" field.</summary>
    public const int CapBalanceFieldNumber = 12;
    private uint capBalance_;
    public uint CapBalance {
      get { return capBalance_; }
      set {
        capBalance_ = value;
      }
    }

    /// <summary>Field number for the "income_per_second" field.</summary>
    public const int IncomePerSecondFieldNumber = 13;
    private float incomePerSecond_;
    public float IncomePerSecond {
      get { return incomePerSecond_; }
      set {
        incomePerSecond_ = value;
      }
    }

    /// <summary>Field number for the "service_hash" field.</summary>
    public const int ServiceHashFieldNumber = 14;
    private uint serviceHash_;
    public uint ServiceHash {
      get { return serviceHash_; }
      set {
        serviceHash_ = value;
      }
    }

    /// <summary>Field number for the "method_id" field.</summary>
    public const int MethodIdFieldNumber = 15;
    private uint methodId_;
    public uint MethodId {
      get { return methodId_; }
      set {
        methodId_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as RPCMethodConfig);
    }

    public bool Equals(RPCMethodConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ServiceName != other.ServiceName) return false;
      if (MethodName != other.MethodName) return false;
      if (FixedCallCost != other.FixedCallCost) return false;
      if (FixedPacketSize != other.FixedPacketSize) return false;
      if (VariableMultiplier != other.VariableMultiplier) return false;
      if (Multiplier != other.Multiplier) return false;
      if (RateLimitCount != other.RateLimitCount) return false;
      if (RateLimitSeconds != other.RateLimitSeconds) return false;
      if (MaxPacketSize != other.MaxPacketSize) return false;
      if (MaxEncodedSize != other.MaxEncodedSize) return false;
      if (Timeout != other.Timeout) return false;
      if (CapBalance != other.CapBalance) return false;
      if (IncomePerSecond != other.IncomePerSecond) return false;
      if (ServiceHash != other.ServiceHash) return false;
      if (MethodId != other.MethodId) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (ServiceName.Length != 0) hash ^= ServiceName.GetHashCode();
      if (MethodName.Length != 0) hash ^= MethodName.GetHashCode();
      if (FixedCallCost != 0) hash ^= FixedCallCost.GetHashCode();
      if (FixedPacketSize != 0) hash ^= FixedPacketSize.GetHashCode();
      if (VariableMultiplier != 0F) hash ^= VariableMultiplier.GetHashCode();
      if (Multiplier != 0F) hash ^= Multiplier.GetHashCode();
      if (RateLimitCount != 0) hash ^= RateLimitCount.GetHashCode();
      if (RateLimitSeconds != 0) hash ^= RateLimitSeconds.GetHashCode();
      if (MaxPacketSize != 0) hash ^= MaxPacketSize.GetHashCode();
      if (MaxEncodedSize != 0) hash ^= MaxEncodedSize.GetHashCode();
      if (Timeout != 0F) hash ^= Timeout.GetHashCode();
      if (CapBalance != 0) hash ^= CapBalance.GetHashCode();
      if (IncomePerSecond != 0F) hash ^= IncomePerSecond.GetHashCode();
      if (ServiceHash != 0) hash ^= ServiceHash.GetHashCode();
      if (MethodId != 0) hash ^= MethodId.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (ServiceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ServiceName);
      }
      if (MethodName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(MethodName);
      }
      if (FixedCallCost != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(FixedCallCost);
      }
      if (FixedPacketSize != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(FixedPacketSize);
      }
      if (VariableMultiplier != 0F) {
        output.WriteRawTag(45);
        output.WriteFloat(VariableMultiplier);
      }
      if (Multiplier != 0F) {
        output.WriteRawTag(53);
        output.WriteFloat(Multiplier);
      }
      if (RateLimitCount != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(RateLimitCount);
      }
      if (RateLimitSeconds != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(RateLimitSeconds);
      }
      if (MaxPacketSize != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(MaxPacketSize);
      }
      if (MaxEncodedSize != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(MaxEncodedSize);
      }
      if (Timeout != 0F) {
        output.WriteRawTag(93);
        output.WriteFloat(Timeout);
      }
      if (CapBalance != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(CapBalance);
      }
      if (IncomePerSecond != 0F) {
        output.WriteRawTag(109);
        output.WriteFloat(IncomePerSecond);
      }
      if (ServiceHash != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(ServiceHash);
      }
      if (MethodId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(MethodId);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (ServiceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ServiceName);
      }
      if (MethodName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MethodName);
      }
      if (FixedCallCost != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FixedCallCost);
      }
      if (FixedPacketSize != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FixedPacketSize);
      }
      if (VariableMultiplier != 0F) {
        size += 1 + 4;
      }
      if (Multiplier != 0F) {
        size += 1 + 4;
      }
      if (RateLimitCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RateLimitCount);
      }
      if (RateLimitSeconds != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RateLimitSeconds);
      }
      if (MaxPacketSize != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MaxPacketSize);
      }
      if (MaxEncodedSize != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MaxEncodedSize);
      }
      if (Timeout != 0F) {
        size += 1 + 4;
      }
      if (CapBalance != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CapBalance);
      }
      if (IncomePerSecond != 0F) {
        size += 1 + 4;
      }
      if (ServiceHash != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ServiceHash);
      }
      if (MethodId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MethodId);
      }
      return size;
    }

    public void MergeFrom(RPCMethodConfig other) {
      if (other == null) {
        return;
      }
      if (other.ServiceName.Length != 0) {
        ServiceName = other.ServiceName;
      }
      if (other.MethodName.Length != 0) {
        MethodName = other.MethodName;
      }
      if (other.FixedCallCost != 0) {
        FixedCallCost = other.FixedCallCost;
      }
      if (other.FixedPacketSize != 0) {
        FixedPacketSize = other.FixedPacketSize;
      }
      if (other.VariableMultiplier != 0F) {
        VariableMultiplier = other.VariableMultiplier;
      }
      if (other.Multiplier != 0F) {
        Multiplier = other.Multiplier;
      }
      if (other.RateLimitCount != 0) {
        RateLimitCount = other.RateLimitCount;
      }
      if (other.RateLimitSeconds != 0) {
        RateLimitSeconds = other.RateLimitSeconds;
      }
      if (other.MaxPacketSize != 0) {
        MaxPacketSize = other.MaxPacketSize;
      }
      if (other.MaxEncodedSize != 0) {
        MaxEncodedSize = other.MaxEncodedSize;
      }
      if (other.Timeout != 0F) {
        Timeout = other.Timeout;
      }
      if (other.CapBalance != 0) {
        CapBalance = other.CapBalance;
      }
      if (other.IncomePerSecond != 0F) {
        IncomePerSecond = other.IncomePerSecond;
      }
      if (other.ServiceHash != 0) {
        ServiceHash = other.ServiceHash;
      }
      if (other.MethodId != 0) {
        MethodId = other.MethodId;
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
            ServiceName = input.ReadString();
            break;
          }
          case 18: {
            MethodName = input.ReadString();
            break;
          }
          case 24: {
            FixedCallCost = input.ReadUInt32();
            break;
          }
          case 32: {
            FixedPacketSize = input.ReadUInt32();
            break;
          }
          case 45: {
            VariableMultiplier = input.ReadFloat();
            break;
          }
          case 53: {
            Multiplier = input.ReadFloat();
            break;
          }
          case 56: {
            RateLimitCount = input.ReadUInt32();
            break;
          }
          case 64: {
            RateLimitSeconds = input.ReadUInt32();
            break;
          }
          case 72: {
            MaxPacketSize = input.ReadUInt32();
            break;
          }
          case 80: {
            MaxEncodedSize = input.ReadUInt32();
            break;
          }
          case 93: {
            Timeout = input.ReadFloat();
            break;
          }
          case 96: {
            CapBalance = input.ReadUInt32();
            break;
          }
          case 109: {
            IncomePerSecond = input.ReadFloat();
            break;
          }
          case 112: {
            ServiceHash = input.ReadUInt32();
            break;
          }
          case 120: {
            MethodId = input.ReadUInt32();
            break;
          }
        }
      }
    }

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class RPCMeterConfig : pb::IMessage<RPCMeterConfig> {
    private static readonly pb::MessageParser<RPCMeterConfig> _parser = new pb::MessageParser<RPCMeterConfig>(() => new RPCMeterConfig());
    public static pb::MessageParser<RPCMeterConfig> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Bgs.Protocol.Config.RpcConfigReflection.Descriptor.MessageTypes[1]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public RPCMeterConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    public RPCMeterConfig(RPCMeterConfig other) : this() {
      method_ = other.method_.Clone();
      incomePerSecond_ = other.incomePerSecond_;
      initialBalance_ = other.initialBalance_;
      capBalance_ = other.capBalance_;
      startupPeriod_ = other.startupPeriod_;
    }

    public RPCMeterConfig Clone() {
      return new RPCMeterConfig(this);
    }

    /// <summary>Field number for the "method" field.</summary>
    public const int MethodFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Bgs.Protocol.Config.RPCMethodConfig> _repeated_method_codec
        = pb::FieldCodec.ForMessage(10, global::Bgs.Protocol.Config.RPCMethodConfig.Parser);
    private readonly pbc::RepeatedField<global::Bgs.Protocol.Config.RPCMethodConfig> method_ = new pbc::RepeatedField<global::Bgs.Protocol.Config.RPCMethodConfig>();
    public pbc::RepeatedField<global::Bgs.Protocol.Config.RPCMethodConfig> Method {
      get { return method_; }
    }

    /// <summary>Field number for the "income_per_second" field.</summary>
    public const int IncomePerSecondFieldNumber = 2;
    private uint incomePerSecond_;
    public uint IncomePerSecond {
      get { return incomePerSecond_; }
      set {
        incomePerSecond_ = value;
      }
    }

    /// <summary>Field number for the "initial_balance" field.</summary>
    public const int InitialBalanceFieldNumber = 3;
    private uint initialBalance_;
    public uint InitialBalance {
      get { return initialBalance_; }
      set {
        initialBalance_ = value;
      }
    }

    /// <summary>Field number for the "cap_balance" field.</summary>
    public const int CapBalanceFieldNumber = 4;
    private uint capBalance_;
    public uint CapBalance {
      get { return capBalance_; }
      set {
        capBalance_ = value;
      }
    }

    /// <summary>Field number for the "startup_period" field.</summary>
    public const int StartupPeriodFieldNumber = 5;
    private float startupPeriod_;
    public float StartupPeriod {
      get { return startupPeriod_; }
      set {
        startupPeriod_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as RPCMeterConfig);
    }

    public bool Equals(RPCMeterConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!method_.Equals(other.method_)) return false;
      if (IncomePerSecond != other.IncomePerSecond) return false;
      if (InitialBalance != other.InitialBalance) return false;
      if (CapBalance != other.CapBalance) return false;
      if (StartupPeriod != other.StartupPeriod) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      hash ^= method_.GetHashCode();
      if (IncomePerSecond != 0) hash ^= IncomePerSecond.GetHashCode();
      if (InitialBalance != 0) hash ^= InitialBalance.GetHashCode();
      if (CapBalance != 0) hash ^= CapBalance.GetHashCode();
      if (StartupPeriod != 0F) hash ^= StartupPeriod.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      method_.WriteTo(output, _repeated_method_codec);
      if (IncomePerSecond != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(IncomePerSecond);
      }
      if (InitialBalance != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(InitialBalance);
      }
      if (CapBalance != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(CapBalance);
      }
      if (StartupPeriod != 0F) {
        output.WriteRawTag(45);
        output.WriteFloat(StartupPeriod);
      }
    }

    public int CalculateSize() {
      int size = 0;
      size += method_.CalculateSize(_repeated_method_codec);
      if (IncomePerSecond != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(IncomePerSecond);
      }
      if (InitialBalance != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(InitialBalance);
      }
      if (CapBalance != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CapBalance);
      }
      if (StartupPeriod != 0F) {
        size += 1 + 4;
      }
      return size;
    }

    public void MergeFrom(RPCMeterConfig other) {
      if (other == null) {
        return;
      }
      method_.Add(other.method_);
      if (other.IncomePerSecond != 0) {
        IncomePerSecond = other.IncomePerSecond;
      }
      if (other.InitialBalance != 0) {
        InitialBalance = other.InitialBalance;
      }
      if (other.CapBalance != 0) {
        CapBalance = other.CapBalance;
      }
      if (other.StartupPeriod != 0F) {
        StartupPeriod = other.StartupPeriod;
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
            method_.AddEntriesFrom(input, _repeated_method_codec);
            break;
          }
          case 16: {
            IncomePerSecond = input.ReadUInt32();
            break;
          }
          case 24: {
            InitialBalance = input.ReadUInt32();
            break;
          }
          case 32: {
            CapBalance = input.ReadUInt32();
            break;
          }
          case 45: {
            StartupPeriod = input.ReadFloat();
            break;
          }
        }
      }
    }

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class ProtocolAlias : pb::IMessage<ProtocolAlias> {
    private static readonly pb::MessageParser<ProtocolAlias> _parser = new pb::MessageParser<ProtocolAlias>(() => new ProtocolAlias());
    public static pb::MessageParser<ProtocolAlias> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Bgs.Protocol.Config.RpcConfigReflection.Descriptor.MessageTypes[2]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public ProtocolAlias() {
      OnConstruction();
    }

    partial void OnConstruction();

    public ProtocolAlias(ProtocolAlias other) : this() {
      serverServiceName_ = other.serverServiceName_;
      clientServiceName_ = other.clientServiceName_;
    }

    public ProtocolAlias Clone() {
      return new ProtocolAlias(this);
    }

    /// <summary>Field number for the "server_service_name" field.</summary>
    public const int ServerServiceNameFieldNumber = 1;
    private string serverServiceName_ = "";
    public string ServerServiceName {
      get { return serverServiceName_; }
      set {
        serverServiceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "client_service_name" field.</summary>
    public const int ClientServiceNameFieldNumber = 2;
    private string clientServiceName_ = "";
    public string ClientServiceName {
      get { return clientServiceName_; }
      set {
        clientServiceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    public override bool Equals(object other) {
      return Equals(other as ProtocolAlias);
    }

    public bool Equals(ProtocolAlias other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ServerServiceName != other.ServerServiceName) return false;
      if (ClientServiceName != other.ClientServiceName) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      hash ^= ServerServiceName.GetHashCode();
      hash ^= ClientServiceName.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      {
        output.WriteRawTag(10);
        output.WriteString(ServerServiceName);
      }
      {
        output.WriteRawTag(18);
        output.WriteString(ClientServiceName);
      }
    }

    public int CalculateSize() {
      int size = 0;
      {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ServerServiceName);
      }
      {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ClientServiceName);
      }
      return size;
    }

    public void MergeFrom(ProtocolAlias other) {
      if (other == null) {
        return;
      }
      if (other.ServerServiceName.Length != 0) {
        ServerServiceName = other.ServerServiceName;
      }
      if (other.ClientServiceName.Length != 0) {
        ClientServiceName = other.ClientServiceName;
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
            ServerServiceName = input.ReadString();
            break;
          }
          case 18: {
            ClientServiceName = input.ReadString();
            break;
          }
        }
      }
    }

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class ServiceAliases : pb::IMessage<ServiceAliases> {
    private static readonly pb::MessageParser<ServiceAliases> _parser = new pb::MessageParser<ServiceAliases>(() => new ServiceAliases());
    public static pb::MessageParser<ServiceAliases> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Bgs.Protocol.Config.RpcConfigReflection.Descriptor.MessageTypes[3]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public ServiceAliases() {
      OnConstruction();
    }

    partial void OnConstruction();

    public ServiceAliases(ServiceAliases other) : this() {
      protocolAlias_ = other.protocolAlias_.Clone();
    }

    public ServiceAliases Clone() {
      return new ServiceAliases(this);
    }

    /// <summary>Field number for the "protocol_alias" field.</summary>
    public const int ProtocolAliasFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Bgs.Protocol.Config.ProtocolAlias> _repeated_protocolAlias_codec
        = pb::FieldCodec.ForMessage(10, global::Bgs.Protocol.Config.ProtocolAlias.Parser);
    private readonly pbc::RepeatedField<global::Bgs.Protocol.Config.ProtocolAlias> protocolAlias_ = new pbc::RepeatedField<global::Bgs.Protocol.Config.ProtocolAlias>();
    public pbc::RepeatedField<global::Bgs.Protocol.Config.ProtocolAlias> ProtocolAlias {
      get { return protocolAlias_; }
    }

    public override bool Equals(object other) {
      return Equals(other as ServiceAliases);
    }

    public bool Equals(ServiceAliases other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!protocolAlias_.Equals(other.protocolAlias_)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      hash ^= protocolAlias_.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      protocolAlias_.WriteTo(output, _repeated_protocolAlias_codec);
    }

    public int CalculateSize() {
      int size = 0;
      size += protocolAlias_.CalculateSize(_repeated_protocolAlias_codec);
      return size;
    }

    public void MergeFrom(ServiceAliases other) {
      if (other == null) {
        return;
      }
      protocolAlias_.Add(other.protocolAlias_);
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            protocolAlias_.AddEntriesFrom(input, _repeated_protocolAlias_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
