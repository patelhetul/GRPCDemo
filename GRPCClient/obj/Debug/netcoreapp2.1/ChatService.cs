// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: chat_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace GRPCDemo {

  /// <summary>Holder for reflection information generated from chat_service.proto</summary>
  public static partial class ChatServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for chat_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChatServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJjaGF0X3NlcnZpY2UucHJvdG8SCEdSUENEZW1vIkUKE0pvaW5DdXN0b21l",
            "clJlcXVlc3QSLgoIY3VzdG9tZXIYASABKAsyHC5HUlBDRGVtby5DdXN0b21l",
            "clByb3RvTW9kZWwiJAoRSm9pbkN1c3RvbWVyUmVwbHkSDwoHcm9vbV9pZBgB",
            "IAEoBSJIChJDdXN0b21lclByb3RvTW9kZWwSCgoCSWQYASABKAkSDAoEbmFt",
            "ZRgCIAEoCRIYChBjb2xvcl9pbl9jb25zb2xlGAMgASgJImoKC0NoYXRNZXNz",
            "YWdlEhMKC2N1c3RvbWVyX2lkGAEgASgJEhUKDWN1c3RvbWVyX25hbWUYBSAB",
            "KAkSDwoHbWVzc2FnZRgCIAEoCRINCgVjb2xvchgDIAEoCRIPCgdyb29tX2lk",
            "GAQgASgFMqgBCgtDaGF0U2VydmljZRJOChBKb2luQ3VzdG9tZXJDaGF0Eh0u",
            "R1JQQ0RlbW8uSm9pbkN1c3RvbWVyUmVxdWVzdBobLkdSUENEZW1vLkpvaW5D",
            "dXN0b21lclJlcGx5EkkKFVNlbmRNZXNzYWdlVG9DaGF0Um9vbRIVLkdSUENE",
            "ZW1vLkNoYXRNZXNzYWdlGhUuR1JQQ0RlbW8uQ2hhdE1lc3NhZ2UoATABYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::GRPCDemo.JoinCustomerRequest), global::GRPCDemo.JoinCustomerRequest.Parser, new[]{ "Customer" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GRPCDemo.JoinCustomerReply), global::GRPCDemo.JoinCustomerReply.Parser, new[]{ "RoomId" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GRPCDemo.CustomerProtoModel), global::GRPCDemo.CustomerProtoModel.Parser, new[]{ "Id", "Name", "ColorInConsole" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GRPCDemo.ChatMessage), global::GRPCDemo.ChatMessage.Parser, new[]{ "CustomerId", "CustomerName", "Message", "Color", "RoomId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class JoinCustomerRequest : pb::IMessage<JoinCustomerRequest> {
    private static readonly pb::MessageParser<JoinCustomerRequest> _parser = new pb::MessageParser<JoinCustomerRequest>(() => new JoinCustomerRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<JoinCustomerRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GRPCDemo.ChatServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public JoinCustomerRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public JoinCustomerRequest(JoinCustomerRequest other) : this() {
      customer_ = other.customer_ != null ? other.customer_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public JoinCustomerRequest Clone() {
      return new JoinCustomerRequest(this);
    }

    /// <summary>Field number for the "customer" field.</summary>
    public const int CustomerFieldNumber = 1;
    private global::GRPCDemo.CustomerProtoModel customer_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::GRPCDemo.CustomerProtoModel Customer {
      get { return customer_; }
      set {
        customer_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as JoinCustomerRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(JoinCustomerRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Customer, other.Customer)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (customer_ != null) hash ^= Customer.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (customer_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Customer);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (customer_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Customer);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(JoinCustomerRequest other) {
      if (other == null) {
        return;
      }
      if (other.customer_ != null) {
        if (customer_ == null) {
          Customer = new global::GRPCDemo.CustomerProtoModel();
        }
        Customer.MergeFrom(other.Customer);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (customer_ == null) {
              Customer = new global::GRPCDemo.CustomerProtoModel();
            }
            input.ReadMessage(Customer);
            break;
          }
        }
      }
    }

  }

  public sealed partial class JoinCustomerReply : pb::IMessage<JoinCustomerReply> {
    private static readonly pb::MessageParser<JoinCustomerReply> _parser = new pb::MessageParser<JoinCustomerReply>(() => new JoinCustomerReply());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<JoinCustomerReply> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GRPCDemo.ChatServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public JoinCustomerReply() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public JoinCustomerReply(JoinCustomerReply other) : this() {
      roomId_ = other.roomId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public JoinCustomerReply Clone() {
      return new JoinCustomerReply(this);
    }

    /// <summary>Field number for the "room_id" field.</summary>
    public const int RoomIdFieldNumber = 1;
    private int roomId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int RoomId {
      get { return roomId_; }
      set {
        roomId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as JoinCustomerReply);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(JoinCustomerReply other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RoomId != other.RoomId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (RoomId != 0) hash ^= RoomId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (RoomId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(RoomId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (RoomId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(RoomId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(JoinCustomerReply other) {
      if (other == null) {
        return;
      }
      if (other.RoomId != 0) {
        RoomId = other.RoomId;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            RoomId = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class CustomerProtoModel : pb::IMessage<CustomerProtoModel> {
    private static readonly pb::MessageParser<CustomerProtoModel> _parser = new pb::MessageParser<CustomerProtoModel>(() => new CustomerProtoModel());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CustomerProtoModel> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GRPCDemo.ChatServiceReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomerProtoModel() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomerProtoModel(CustomerProtoModel other) : this() {
      id_ = other.id_;
      name_ = other.name_;
      colorInConsole_ = other.colorInConsole_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomerProtoModel Clone() {
      return new CustomerProtoModel(this);
    }

    /// <summary>Field number for the "Id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 2;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "color_in_console" field.</summary>
    public const int ColorInConsoleFieldNumber = 3;
    private string colorInConsole_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ColorInConsole {
      get { return colorInConsole_; }
      set {
        colorInConsole_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CustomerProtoModel);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CustomerProtoModel other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Name != other.Name) return false;
      if (ColorInConsole != other.ColorInConsole) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (ColorInConsole.Length != 0) hash ^= ColorInConsole.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (ColorInConsole.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ColorInConsole);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (ColorInConsole.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ColorInConsole);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CustomerProtoModel other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.ColorInConsole.Length != 0) {
        ColorInConsole = other.ColorInConsole;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 26: {
            ColorInConsole = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class ChatMessage : pb::IMessage<ChatMessage> {
    private static readonly pb::MessageParser<ChatMessage> _parser = new pb::MessageParser<ChatMessage>(() => new ChatMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ChatMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GRPCDemo.ChatServiceReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChatMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChatMessage(ChatMessage other) : this() {
      customerId_ = other.customerId_;
      customerName_ = other.customerName_;
      message_ = other.message_;
      color_ = other.color_;
      roomId_ = other.roomId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChatMessage Clone() {
      return new ChatMessage(this);
    }

    /// <summary>Field number for the "customer_id" field.</summary>
    public const int CustomerIdFieldNumber = 1;
    private string customerId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CustomerId {
      get { return customerId_; }
      set {
        customerId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "customer_name" field.</summary>
    public const int CustomerNameFieldNumber = 5;
    private string customerName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CustomerName {
      get { return customerName_; }
      set {
        customerName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "message" field.</summary>
    public const int MessageFieldNumber = 2;
    private string message_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Message {
      get { return message_; }
      set {
        message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "color" field.</summary>
    public const int ColorFieldNumber = 3;
    private string color_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Color {
      get { return color_; }
      set {
        color_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "room_id" field.</summary>
    public const int RoomIdFieldNumber = 4;
    private int roomId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int RoomId {
      get { return roomId_; }
      set {
        roomId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ChatMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ChatMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CustomerId != other.CustomerId) return false;
      if (CustomerName != other.CustomerName) return false;
      if (Message != other.Message) return false;
      if (Color != other.Color) return false;
      if (RoomId != other.RoomId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (CustomerId.Length != 0) hash ^= CustomerId.GetHashCode();
      if (CustomerName.Length != 0) hash ^= CustomerName.GetHashCode();
      if (Message.Length != 0) hash ^= Message.GetHashCode();
      if (Color.Length != 0) hash ^= Color.GetHashCode();
      if (RoomId != 0) hash ^= RoomId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (CustomerId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(CustomerId);
      }
      if (Message.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Message);
      }
      if (Color.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Color);
      }
      if (RoomId != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(RoomId);
      }
      if (CustomerName.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(CustomerName);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (CustomerId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CustomerId);
      }
      if (CustomerName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CustomerName);
      }
      if (Message.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      if (Color.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Color);
      }
      if (RoomId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(RoomId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ChatMessage other) {
      if (other == null) {
        return;
      }
      if (other.CustomerId.Length != 0) {
        CustomerId = other.CustomerId;
      }
      if (other.CustomerName.Length != 0) {
        CustomerName = other.CustomerName;
      }
      if (other.Message.Length != 0) {
        Message = other.Message;
      }
      if (other.Color.Length != 0) {
        Color = other.Color;
      }
      if (other.RoomId != 0) {
        RoomId = other.RoomId;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            CustomerId = input.ReadString();
            break;
          }
          case 18: {
            Message = input.ReadString();
            break;
          }
          case 26: {
            Color = input.ReadString();
            break;
          }
          case 32: {
            RoomId = input.ReadInt32();
            break;
          }
          case 42: {
            CustomerName = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code