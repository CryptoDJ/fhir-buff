// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: location.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Fhirbuffs {

  namespace Proto {

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public static partial class Location {

      #region Descriptor
      public static pbr::FileDescriptor Descriptor {
        get { return descriptor; }
      }
      private static pbr::FileDescriptor descriptor;

      static Location() {
        byte[] descriptorData = global::System.Convert.FromBase64String(
            string.Concat(
              "Cg5sb2NhdGlvbi5wcm90bxIJZmhpcmJ1ZmZzGhBwcmltaXRpdmVzLnByb3Rv",
              "Iu4DCghMb2NhdGlvbhIpCgppZGVudGlmaWVyGAEgAygLMhUuZmhpcmJ1ZmZz",
              "LklkZW50aWZpZXISDgoGc3RhdHVzGAIgASgJEgwKBG5hbWUYAyABKAkSEwoL",
              "ZGVzY3JpcHRpb24YBCABKAkSLgoEbW9kZRgFIAEoDjIgLmZoaXJidWZmcy5M",
              "b2NhdGlvbi5Mb2NhdGlvbk1vZGUSKAoEdHlwZRgGIAEoCzIaLmZoaXJidWZm",
              "cy5Db2RlYWJsZUNvbmNlcHQSKAoHdGVsZWNvbRgHIAMoCzIXLmZoaXJidWZm",
              "cy5Db250YWN0UG9pbnQSIwoHYWRkcmVzcxgIIAEoCzISLmZoaXJidWZmcy5B",
              "ZGRyZXNzEjAKDHBoeXNpY2FsVHlwZRgJIAEoCzIaLmZoaXJidWZmcy5Db2Rl",
              "YWJsZUNvbmNlcHQSJQoIcG9zaXRpb24YCiABKAsyEy5maGlyYnVmZnMuUG9z",
              "aXRpb24SNQoUbWFuYWdpbmdPcmdhbml6YXRpb24YCyABKAsyFy5maGlyYnVm",
              "ZnMuT3JnYW5pemF0aW9uEiMKBnBhcnRPZhgMIAEoCzITLmZoaXJidWZmcy5M",
              "b2NhdGlvbiImCgxMb2NhdGlvbk1vZGUSDAoIaW5zdGFuY2UQABIICgRraW5k",
              "EAFiBnByb3RvMw=="));
        descriptor = pbr::FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData,
            new pbr::FileDescriptor[] { global::Fhirbuffs.Primitives.Descriptor, },
            new pbr::GeneratedCodeInfo(null, new pbr::GeneratedCodeInfo[] {
              new pbr::GeneratedCodeInfo(typeof(global::Fhirbuffs.Location), new[]{ "Identifier", "Status", "Name", "Description", "Mode", "Type", "Telecom", "Address", "PhysicalType", "Position", "ManagingOrganization", "PartOf" }, null, new[]{ typeof(global::Fhirbuffs.Location.Types.LocationMode) }, null)
            }));
      }
      #endregion

    }
  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Location : pb::IMessage<Location> {
    private static readonly pb::MessageParser<Location> _parser = new pb::MessageParser<Location>(() => new Location());
    public static pb::MessageParser<Location> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Fhirbuffs.Proto.Location.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public Location() {
      OnConstruction();
    }

    partial void OnConstruction();

    public Location(Location other) : this() {
      identifier_ = other.identifier_.Clone();
      status_ = other.status_;
      name_ = other.name_;
      description_ = other.description_;
      mode_ = other.mode_;
      Type = other.type_ != null ? other.Type.Clone() : null;
      telecom_ = other.telecom_.Clone();
      Address = other.address_ != null ? other.Address.Clone() : null;
      PhysicalType = other.physicalType_ != null ? other.PhysicalType.Clone() : null;
      Position = other.position_ != null ? other.Position.Clone() : null;
      ManagingOrganization = other.managingOrganization_ != null ? other.ManagingOrganization.Clone() : null;
      PartOf = other.partOf_ != null ? other.PartOf.Clone() : null;
    }

    public Location Clone() {
      return new Location(this);
    }

    public const int IdentifierFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Fhirbuffs.Identifier> _repeated_identifier_codec
        = pb::FieldCodec.ForMessage(10, global::Fhirbuffs.Identifier.Parser);
    private readonly pbc::RepeatedField<global::Fhirbuffs.Identifier> identifier_ = new pbc::RepeatedField<global::Fhirbuffs.Identifier>();
    public pbc::RepeatedField<global::Fhirbuffs.Identifier> Identifier {
      get { return identifier_; }
    }

    public const int StatusFieldNumber = 2;
    private string status_ = "";
    public string Status {
      get { return status_; }
      set {
        status_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    public const int NameFieldNumber = 3;
    private string name_ = "";
    public string Name {
      get { return name_; }
      set {
        name_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    public const int DescriptionFieldNumber = 4;
    private string description_ = "";
    public string Description {
      get { return description_; }
      set {
        description_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    public const int ModeFieldNumber = 5;
    private global::Fhirbuffs.Location.Types.LocationMode mode_ = global::Fhirbuffs.Location.Types.LocationMode.instance;
    public global::Fhirbuffs.Location.Types.LocationMode Mode {
      get { return mode_; }
      set {
        mode_ = value;
      }
    }

    public const int TypeFieldNumber = 6;
    private global::Fhirbuffs.CodeableConcept type_;
    public global::Fhirbuffs.CodeableConcept Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    public const int TelecomFieldNumber = 7;
    private static readonly pb::FieldCodec<global::Fhirbuffs.ContactPoint> _repeated_telecom_codec
        = pb::FieldCodec.ForMessage(58, global::Fhirbuffs.ContactPoint.Parser);
    private readonly pbc::RepeatedField<global::Fhirbuffs.ContactPoint> telecom_ = new pbc::RepeatedField<global::Fhirbuffs.ContactPoint>();
    public pbc::RepeatedField<global::Fhirbuffs.ContactPoint> Telecom {
      get { return telecom_; }
    }

    public const int AddressFieldNumber = 8;
    private global::Fhirbuffs.Address address_;
    public global::Fhirbuffs.Address Address {
      get { return address_; }
      set {
        address_ = value;
      }
    }

    public const int PhysicalTypeFieldNumber = 9;
    private global::Fhirbuffs.CodeableConcept physicalType_;
    public global::Fhirbuffs.CodeableConcept PhysicalType {
      get { return physicalType_; }
      set {
        physicalType_ = value;
      }
    }

    public const int PositionFieldNumber = 10;
    private global::Fhirbuffs.Position position_;
    public global::Fhirbuffs.Position Position {
      get { return position_; }
      set {
        position_ = value;
      }
    }

    public const int ManagingOrganizationFieldNumber = 11;
    private global::Fhirbuffs.Organization managingOrganization_;
    public global::Fhirbuffs.Organization ManagingOrganization {
      get { return managingOrganization_; }
      set {
        managingOrganization_ = value;
      }
    }

    public const int PartOfFieldNumber = 12;
    private global::Fhirbuffs.Location partOf_;
    public global::Fhirbuffs.Location PartOf {
      get { return partOf_; }
      set {
        partOf_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as Location);
    }

    public bool Equals(Location other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!identifier_.Equals(other.identifier_)) return false;
      if (Status != other.Status) return false;
      if (Name != other.Name) return false;
      if (Description != other.Description) return false;
      if (Mode != other.Mode) return false;
      if (!object.Equals(Type, other.Type)) return false;
      if(!telecom_.Equals(other.telecom_)) return false;
      if (!object.Equals(Address, other.Address)) return false;
      if (!object.Equals(PhysicalType, other.PhysicalType)) return false;
      if (!object.Equals(Position, other.Position)) return false;
      if (!object.Equals(ManagingOrganization, other.ManagingOrganization)) return false;
      if (!object.Equals(PartOf, other.PartOf)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      hash ^= identifier_.GetHashCode();
      if (Status.Length != 0) hash ^= Status.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      if (Mode != global::Fhirbuffs.Location.Types.LocationMode.instance) hash ^= Mode.GetHashCode();
      if (type_ != null) hash ^= Type.GetHashCode();
      hash ^= telecom_.GetHashCode();
      if (address_ != null) hash ^= Address.GetHashCode();
      if (physicalType_ != null) hash ^= PhysicalType.GetHashCode();
      if (position_ != null) hash ^= Position.GetHashCode();
      if (managingOrganization_ != null) hash ^= ManagingOrganization.GetHashCode();
      if (partOf_ != null) hash ^= PartOf.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.Default.Format(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      identifier_.WriteTo(output, _repeated_identifier_codec);
      if (Status.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Status);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Name);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Description);
      }
      if (Mode != global::Fhirbuffs.Location.Types.LocationMode.instance) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Mode);
      }
      if (type_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(Type);
      }
      telecom_.WriteTo(output, _repeated_telecom_codec);
      if (address_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(Address);
      }
      if (physicalType_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(PhysicalType);
      }
      if (position_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(Position);
      }
      if (managingOrganization_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(ManagingOrganization);
      }
      if (partOf_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(PartOf);
      }
    }

    public int CalculateSize() {
      int size = 0;
      size += identifier_.CalculateSize(_repeated_identifier_codec);
      if (Status.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Status);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      if (Mode != global::Fhirbuffs.Location.Types.LocationMode.instance) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Mode);
      }
      if (type_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Type);
      }
      size += telecom_.CalculateSize(_repeated_telecom_codec);
      if (address_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Address);
      }
      if (physicalType_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PhysicalType);
      }
      if (position_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Position);
      }
      if (managingOrganization_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ManagingOrganization);
      }
      if (partOf_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PartOf);
      }
      return size;
    }

    public void MergeFrom(Location other) {
      if (other == null) {
        return;
      }
      identifier_.Add(other.identifier_);
      if (other.Status.Length != 0) {
        Status = other.Status;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Description.Length != 0) {
        Description = other.Description;
      }
      if (other.Mode != global::Fhirbuffs.Location.Types.LocationMode.instance) {
        Mode = other.Mode;
      }
      if (other.type_ != null) {
        if (type_ == null) {
          type_ = new global::Fhirbuffs.CodeableConcept();
        }
        Type.MergeFrom(other.Type);
      }
      telecom_.Add(other.telecom_);
      if (other.address_ != null) {
        if (address_ == null) {
          address_ = new global::Fhirbuffs.Address();
        }
        Address.MergeFrom(other.Address);
      }
      if (other.physicalType_ != null) {
        if (physicalType_ == null) {
          physicalType_ = new global::Fhirbuffs.CodeableConcept();
        }
        PhysicalType.MergeFrom(other.PhysicalType);
      }
      if (other.position_ != null) {
        if (position_ == null) {
          position_ = new global::Fhirbuffs.Position();
        }
        Position.MergeFrom(other.Position);
      }
      if (other.managingOrganization_ != null) {
        if (managingOrganization_ == null) {
          managingOrganization_ = new global::Fhirbuffs.Organization();
        }
        ManagingOrganization.MergeFrom(other.ManagingOrganization);
      }
      if (other.partOf_ != null) {
        if (partOf_ == null) {
          partOf_ = new global::Fhirbuffs.Location();
        }
        PartOf.MergeFrom(other.PartOf);
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
            identifier_.AddEntriesFrom(input, _repeated_identifier_codec);
            break;
          }
          case 18: {
            Status = input.ReadString();
            break;
          }
          case 26: {
            Name = input.ReadString();
            break;
          }
          case 34: {
            Description = input.ReadString();
            break;
          }
          case 40: {
            mode_ = (global::Fhirbuffs.Location.Types.LocationMode) input.ReadEnum();
            break;
          }
          case 50: {
            if (type_ == null) {
              type_ = new global::Fhirbuffs.CodeableConcept();
            }
            input.ReadMessage(type_);
            break;
          }
          case 58: {
            telecom_.AddEntriesFrom(input, _repeated_telecom_codec);
            break;
          }
          case 66: {
            if (address_ == null) {
              address_ = new global::Fhirbuffs.Address();
            }
            input.ReadMessage(address_);
            break;
          }
          case 74: {
            if (physicalType_ == null) {
              physicalType_ = new global::Fhirbuffs.CodeableConcept();
            }
            input.ReadMessage(physicalType_);
            break;
          }
          case 82: {
            if (position_ == null) {
              position_ = new global::Fhirbuffs.Position();
            }
            input.ReadMessage(position_);
            break;
          }
          case 90: {
            if (managingOrganization_ == null) {
              managingOrganization_ = new global::Fhirbuffs.Organization();
            }
            input.ReadMessage(managingOrganization_);
            break;
          }
          case 98: {
            if (partOf_ == null) {
              partOf_ = new global::Fhirbuffs.Location();
            }
            input.ReadMessage(partOf_);
            break;
          }
        }
      }
    }

    #region Nested types
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public static partial class Types {
      public enum LocationMode {
        instance = 0,
        kind = 1,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
