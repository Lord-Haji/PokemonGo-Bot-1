// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Networking/Responses/EncounterResponse.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Responses {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/EncounterResponse.proto</summary>
  public static partial class EncounterResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Responses/EncounterResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EncounterResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjdQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL0VuY291bnRlclJl",
            "c3BvbnNlLnByb3RvEh9QT0dPUHJvdG9zLk5ldHdvcmtpbmcuUmVzcG9uc2Vz",
            "GjBQT0dPUHJvdG9zL0RhdGEvQ2FwdHVyZS9DYXB0dXJlUHJvYmFiaWxpdHku",
            "cHJvdG8aJlBPR09Qcm90b3MvSW52ZW50b3J5L0l0ZW0vSXRlbUlkLnByb3Rv",
            "GihQT0dPUHJvdG9zL01hcC9Qb2tlbW9uL1dpbGRQb2tlbW9uLnByb3RvIpAF",
            "ChFFbmNvdW50ZXJSZXNwb25zZRI5Cgx3aWxkX3Bva2Vtb24YASABKAsyIy5Q",
            "T0dPUHJvdG9zLk1hcC5Qb2tlbW9uLldpbGRQb2tlbW9uElEKCmJhY2tncm91",
            "bmQYAiABKA4yPS5QT0dPUHJvdG9zLk5ldHdvcmtpbmcuUmVzcG9uc2VzLkVu",
            "Y291bnRlclJlc3BvbnNlLkJhY2tncm91bmQSSQoGc3RhdHVzGAMgASgOMjku",
            "UE9HT1Byb3Rvcy5OZXR3b3JraW5nLlJlc3BvbnNlcy5FbmNvdW50ZXJSZXNw",
            "b25zZS5TdGF0dXMSSAoTY2FwdHVyZV9wcm9iYWJpbGl0eRgEIAEoCzIrLlBP",
            "R09Qcm90b3MuRGF0YS5DYXB0dXJlLkNhcHR1cmVQcm9iYWJpbGl0eRI2Cgth",
            "Y3RpdmVfaXRlbRgFIAEoDjIhLlBPR09Qcm90b3MuSW52ZW50b3J5Lkl0ZW0u",
            "SXRlbUlkIiIKCkJhY2tncm91bmQSCAoEUEFSSxAAEgoKBkRFU0VSVBABIvsB",
            "CgZTdGF0dXMSEwoPRU5DT1VOVEVSX0VSUk9SEAASFQoRRU5DT1VOVEVSX1NV",
            "Q0NFU1MQARIXChNFTkNPVU5URVJfTk9UX0ZPVU5EEAISFAoQRU5DT1VOVEVS",
            "X0NMT1NFRBADEhoKFkVOQ09VTlRFUl9QT0tFTU9OX0ZMRUQQBBIaChZFTkNP",
            "VU5URVJfTk9UX0lOX1JBTkdFEAUSHgoaRU5DT1VOVEVSX0FMUkVBRFlfSEFQ",
            "UEVORUQQBhIaChZQT0tFTU9OX0lOVkVOVE9SWV9GVUxMEAcSIgoeRU5DT1VO",
            "VEVSX0JMT0NLRURfQllfQU5USUNIRUFUEAhiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Data.Capture.CaptureProbabilityReflection.Descriptor, global::POGOProtos.Inventory.Item.ItemIdReflection.Descriptor, global::POGOProtos.Map.Pokemon.WildPokemonReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Responses.EncounterResponse), global::POGOProtos.Networking.Responses.EncounterResponse.Parser, new[]{ "WildPokemon", "Background", "Status", "CaptureProbability", "ActiveItem" }, null, new[]{ typeof(global::POGOProtos.Networking.Responses.EncounterResponse.Types.Background), typeof(global::POGOProtos.Networking.Responses.EncounterResponse.Types.Status) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EncounterResponse : pb::IMessage<EncounterResponse> {
    private static readonly pb::MessageParser<EncounterResponse> _parser = new pb::MessageParser<EncounterResponse>(() => new EncounterResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<EncounterResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Responses.EncounterResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EncounterResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EncounterResponse(EncounterResponse other) : this() {
      WildPokemon = other.wildPokemon_ != null ? other.WildPokemon.Clone() : null;
      background_ = other.background_;
      status_ = other.status_;
      CaptureProbability = other.captureProbability_ != null ? other.CaptureProbability.Clone() : null;
      activeItem_ = other.activeItem_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EncounterResponse Clone() {
      return new EncounterResponse(this);
    }

    /// <summary>Field number for the "wild_pokemon" field.</summary>
    public const int WildPokemonFieldNumber = 1;
    private global::POGOProtos.Map.Pokemon.WildPokemon wildPokemon_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Map.Pokemon.WildPokemon WildPokemon {
      get { return wildPokemon_; }
      set {
        wildPokemon_ = value;
      }
    }

    /// <summary>Field number for the "background" field.</summary>
    public const int BackgroundFieldNumber = 2;
    private global::POGOProtos.Networking.Responses.EncounterResponse.Types.Background background_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Networking.Responses.EncounterResponse.Types.Background Background {
      get { return background_; }
      set {
        background_ = value;
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 3;
    private global::POGOProtos.Networking.Responses.EncounterResponse.Types.Status status_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Networking.Responses.EncounterResponse.Types.Status Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "capture_probability" field.</summary>
    public const int CaptureProbabilityFieldNumber = 4;
    private global::POGOProtos.Data.Capture.CaptureProbability captureProbability_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.Capture.CaptureProbability CaptureProbability {
      get { return captureProbability_; }
      set {
        captureProbability_ = value;
      }
    }

    /// <summary>Field number for the "active_item" field.</summary>
    public const int ActiveItemFieldNumber = 5;
    private global::POGOProtos.Inventory.Item.ItemId activeItem_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Inventory.Item.ItemId ActiveItem {
      get { return activeItem_; }
      set {
        activeItem_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as EncounterResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(EncounterResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(WildPokemon, other.WildPokemon)) return false;
      if (Background != other.Background) return false;
      if (Status != other.Status) return false;
      if (!object.Equals(CaptureProbability, other.CaptureProbability)) return false;
      if (ActiveItem != other.ActiveItem) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (wildPokemon_ != null) hash ^= WildPokemon.GetHashCode();
      if (Background != 0) hash ^= Background.GetHashCode();
      if (Status != 0) hash ^= Status.GetHashCode();
      if (captureProbability_ != null) hash ^= CaptureProbability.GetHashCode();
      if (ActiveItem != 0) hash ^= ActiveItem.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (wildPokemon_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(WildPokemon);
      }
      if (Background != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Background);
      }
      if (Status != 0) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Status);
      }
      if (captureProbability_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(CaptureProbability);
      }
      if (ActiveItem != 0) {
        output.WriteRawTag(40);
        output.WriteEnum((int) ActiveItem);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (wildPokemon_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(WildPokemon);
      }
      if (Background != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Background);
      }
      if (Status != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (captureProbability_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CaptureProbability);
      }
      if (ActiveItem != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ActiveItem);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(EncounterResponse other) {
      if (other == null) {
        return;
      }
      if (other.wildPokemon_ != null) {
        if (wildPokemon_ == null) {
          wildPokemon_ = new global::POGOProtos.Map.Pokemon.WildPokemon();
        }
        WildPokemon.MergeFrom(other.WildPokemon);
      }
      if (other.Background != 0) {
        Background = other.Background;
      }
      if (other.Status != 0) {
        Status = other.Status;
      }
      if (other.captureProbability_ != null) {
        if (captureProbability_ == null) {
          captureProbability_ = new global::POGOProtos.Data.Capture.CaptureProbability();
        }
        CaptureProbability.MergeFrom(other.CaptureProbability);
      }
      if (other.ActiveItem != 0) {
        ActiveItem = other.ActiveItem;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            if (wildPokemon_ == null) {
              wildPokemon_ = new global::POGOProtos.Map.Pokemon.WildPokemon();
            }
            input.ReadMessage(wildPokemon_);
            break;
          }
          case 16: {
            background_ = (global::POGOProtos.Networking.Responses.EncounterResponse.Types.Background) input.ReadEnum();
            break;
          }
          case 24: {
            status_ = (global::POGOProtos.Networking.Responses.EncounterResponse.Types.Status) input.ReadEnum();
            break;
          }
          case 34: {
            if (captureProbability_ == null) {
              captureProbability_ = new global::POGOProtos.Data.Capture.CaptureProbability();
            }
            input.ReadMessage(captureProbability_);
            break;
          }
          case 40: {
            activeItem_ = (global::POGOProtos.Inventory.Item.ItemId) input.ReadEnum();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the EncounterResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Background {
        [pbr::OriginalName("PARK")] Park = 0,
        [pbr::OriginalName("DESERT")] Desert = 1,
      }

      public enum Status {
        [pbr::OriginalName("ENCOUNTER_ERROR")] EncounterError = 0,
        [pbr::OriginalName("ENCOUNTER_SUCCESS")] EncounterSuccess = 1,
        [pbr::OriginalName("ENCOUNTER_NOT_FOUND")] EncounterNotFound = 2,
        [pbr::OriginalName("ENCOUNTER_CLOSED")] EncounterClosed = 3,
        [pbr::OriginalName("ENCOUNTER_POKEMON_FLED")] EncounterPokemonFled = 4,
        [pbr::OriginalName("ENCOUNTER_NOT_IN_RANGE")] EncounterNotInRange = 5,
        [pbr::OriginalName("ENCOUNTER_ALREADY_HAPPENED")] EncounterAlreadyHappened = 6,
        [pbr::OriginalName("POKEMON_INVENTORY_FULL")] PokemonInventoryFull = 7,
        [pbr::OriginalName("ENCOUNTER_BLOCKED_BY_ANTICHEAT")] EncounterBlockedByAnticheat = 8,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
