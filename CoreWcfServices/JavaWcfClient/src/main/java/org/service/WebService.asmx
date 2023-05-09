<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions xmlns:s="http://www.w3.org/2001/XMLSchema" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:http="http://schemas.xmlsoap.org/wsdl/http/" xmlns:mime="http://schemas.xmlsoap.org/wsdl/mime/" xmlns:tns="http://tempuri.org/" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:tm="http://microsoft.com/wsdl/mime/textMatching/" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" targetNamespace="http://tempuri.org/" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/">
  <wsdl:types>
    <s:schema elementFormDefault="qualified" targetNamespace="http://tempuri.org/">
      <s:element name="Add">
        <s:complexType>
          <s:sequence>
            <s:element minOccurs="1" maxOccurs="1" name="a" type="s:int" />
            <s:element minOccurs="1" maxOccurs="1" name="b" type="s:int" />
          </s:sequence>
        </s:complexType>
      </s:element>
      <s:element name="AddResponse">
        <s:complexType>
          <s:sequence>
            <s:element minOccurs="1" maxOccurs="1" name="AddResult" type="s:int" />
          </s:sequence>
        </s:complexType>
      </s:element>
      <s:element name="Subtract">
        <s:complexType>
          <s:sequence>
            <s:element minOccurs="1" maxOccurs="1" name="a" type="s:int" />
            <s:element minOccurs="1" maxOccurs="1" name="b" type="s:int" />
          </s:sequence>
        </s:complexType>
      </s:element>
      <s:element name="SubtractResponse">
        <s:complexType>
          <s:sequence>
            <s:element minOccurs="1" maxOccurs="1" name="SubtractResult" type="s:int" />
          </s:sequence>
        </s:complexType>
      </s:element>
      <s:element name="Multiply">
        <s:complexType>
          <s:sequence>
            <s:element minOccurs="1" maxOccurs="1" name="a" type="s:int" />
            <s:element minOccurs="1" maxOccurs="1" name="b" type="s:int" />
          </s:sequence>
        </s:complexType>
      </s:element>
      <s:element name="MultiplyResponse">
        <s:complexType>
          <s:sequence>
            <s:element minOccurs="1" maxOccurs="1" name="MultiplyResult" type="s:int" />
          </s:sequence>
        </s:complexType>
      </s:element>
      <s:element name="Divide">
        <s:complexType>
          <s:sequence>
            <s:element minOccurs="1" maxOccurs="1" name="a" type="s:int" />
            <s:element minOccurs="1" maxOccurs="1" name="b" type="s:int" />
          </s:sequence>
        </s:complexType>
      </s:element>
      <s:element name="DivideResponse">
        <s:complexType>
          <s:sequence>
            <s:element minOccurs="1" maxOccurs="1" name="DivideResult" type="s:float" />
          </s:sequence>
        </s:complexType>
      </s:element>
      <s:element name="CelsiusToFahrenheit">
        <s:complexType>
          <s:sequence>
            <s:element minOccurs="1" maxOccurs="1" name="celsius" type="s:double" />
          </s:sequence>
        </s:complexType>
      </s:element>
      <s:element name="CelsiusToFahrenheitResponse">
        <s:complexType>
          <s:sequence>
            <s:element minOccurs="1" maxOccurs="1" name="CelsiusToFahrenheitResult" type="s:double" />
          </s:sequence>
        </s:complexType>
      </s:element>
      <s:element name="FahrenheitToCelsius">
        <s:complexType>
          <s:sequence>
            <s:element minOccurs="1" maxOccurs="1" name="fahrenheit" type="s:double" />
          </s:sequence>
        </s:complexType>
      </s:element>
      <s:element name="FahrenheitToCelsiusResponse">
        <s:complexType>
          <s:sequence>
            <s:element minOccurs="1" maxOccurs="1" name="FahrenheitToCelsiusResult" type="s:double" />
          </s:sequence>
        </s:complexType>
      </s:element>
      <s:element name="CelsiusToKelvin">
        <s:complexType>
          <s:sequence>
            <s:element minOccurs="1" maxOccurs="1" name="celsius" type="s:double" />
          </s:sequence>
        </s:complexType>
      </s:element>
      <s:element name="CelsiusToKelvinResponse">
        <s:complexType>
          <s:sequence>
            <s:element minOccurs="1" maxOccurs="1" name="CelsiusToKelvinResult" type="s:double" />
          </s:sequence>
        </s:complexType>
      </s:element>
      <s:element name="KelvinToCelsius">
        <s:complexType>
          <s:sequence>
            <s:element minOccurs="1" maxOccurs="1" name="kelvin" type="s:double" />
          </s:sequence>
        </s:complexType>
      </s:element>
      <s:element name="KelvinToCelsiusResponse">
        <s:complexType>
          <s:sequence>
            <s:element minOccurs="1" maxOccurs="1" name="KelvinToCelsiusResult" type="s:double" />
          </s:sequence>
        </s:complexType>
      </s:element>
      <s:element name="Max">
        <s:complexType>
          <s:sequence>
            <s:element minOccurs="0" maxOccurs="1" name="numbers" type="tns:ArrayOfInt" />
          </s:sequence>
        </s:complexType>
      </s:element>
      <s:complexType name="ArrayOfInt">
        <s:sequence>
          <s:element minOccurs="0" maxOccurs="unbounded" name="int" type="s:int" />
        </s:sequence>
      </s:complexType>
      <s:element name="MaxResponse">
        <s:complexType>
          <s:sequence>
            <s:element minOccurs="1" maxOccurs="1" name="MaxResult" type="s:int" />
          </s:sequence>
        </s:complexType>
      </s:element>
      <s:element name="GetIndex">
        <s:complexType>
          <s:sequence>
            <s:element minOccurs="0" maxOccurs="1" name="numbers" type="tns:ArrayOfInt" />
            <s:element minOccurs="1" maxOccurs="1" name="number" type="s:int" />
          </s:sequence>
        </s:complexType>
      </s:element>
      <s:element name="GetIndexResponse">
        <s:complexType>
          <s:sequence>
            <s:element minOccurs="1" maxOccurs="1" name="GetIndexResult" type="s:int" />
          </s:sequence>
        </s:complexType>
      </s:element>
      <s:element name="HelloWorld">
        <s:complexType />
      </s:element>
      <s:element name="HelloWorldResponse">
        <s:complexType>
          <s:sequence>
            <s:element minOccurs="0" maxOccurs="1" name="HelloWorldResult" type="s:string" />
          </s:sequence>
        </s:complexType>
      </s:element>
      <s:element name="Reverse">
        <s:complexType>
          <s:sequence>
            <s:element minOccurs="0" maxOccurs="1" name="text" type="s:string" />
          </s:sequence>
        </s:complexType>
      </s:element>
      <s:element name="ReverseResponse">
        <s:complexType>
          <s:sequence>
            <s:element minOccurs="0" maxOccurs="1" name="ReverseResult" type="s:string" />
          </s:sequence>
        </s:complexType>
      </s:element>
      <s:element name="Average">
        <s:complexType>
          <s:sequence>
            <s:element minOccurs="0" maxOccurs="1" name="numbers" type="tns:ArrayOfInt" />
          </s:sequence>
        </s:complexType>
      </s:element>
      <s:element name="AverageResponse">
        <s:complexType>
          <s:sequence>
            <s:element minOccurs="1" maxOccurs="1" name="AverageResult" type="s:double" />
          </s:sequence>
        </s:complexType>
      </s:element>
    </s:schema>
  </wsdl:types>
  <wsdl:message name="AddSoapIn">
    <wsdl:part name="parameters" element="tns:Add" />
  </wsdl:message>
  <wsdl:message name="AddSoapOut">
    <wsdl:part name="parameters" element="tns:AddResponse" />
  </wsdl:message>
  <wsdl:message name="SubtractSoapIn">
    <wsdl:part name="parameters" element="tns:Subtract" />
  </wsdl:message>
  <wsdl:message name="SubtractSoapOut">
    <wsdl:part name="parameters" element="tns:SubtractResponse" />
  </wsdl:message>
  <wsdl:message name="MultiplySoapIn">
    <wsdl:part name="parameters" element="tns:Multiply" />
  </wsdl:message>
  <wsdl:message name="MultiplySoapOut">
    <wsdl:part name="parameters" element="tns:MultiplyResponse" />
  </wsdl:message>
  <wsdl:message name="DivideSoapIn">
    <wsdl:part name="parameters" element="tns:Divide" />
  </wsdl:message>
  <wsdl:message name="DivideSoapOut">
    <wsdl:part name="parameters" element="tns:DivideResponse" />
  </wsdl:message>
  <wsdl:message name="CelsiusToFahrenheitSoapIn">
    <wsdl:part name="parameters" element="tns:CelsiusToFahrenheit" />
  </wsdl:message>
  <wsdl:message name="CelsiusToFahrenheitSoapOut">
    <wsdl:part name="parameters" element="tns:CelsiusToFahrenheitResponse" />
  </wsdl:message>
  <wsdl:message name="FahrenheitToCelsiusSoapIn">
    <wsdl:part name="parameters" element="tns:FahrenheitToCelsius" />
  </wsdl:message>
  <wsdl:message name="FahrenheitToCelsiusSoapOut">
    <wsdl:part name="parameters" element="tns:FahrenheitToCelsiusResponse" />
  </wsdl:message>
  <wsdl:message name="CelsiusToKelvinSoapIn">
    <wsdl:part name="parameters" element="tns:CelsiusToKelvin" />
  </wsdl:message>
  <wsdl:message name="CelsiusToKelvinSoapOut">
    <wsdl:part name="parameters" element="tns:CelsiusToKelvinResponse" />
  </wsdl:message>
  <wsdl:message name="KelvinToCelsiusSoapIn">
    <wsdl:part name="parameters" element="tns:KelvinToCelsius" />
  </wsdl:message>
  <wsdl:message name="KelvinToCelsiusSoapOut">
    <wsdl:part name="parameters" element="tns:KelvinToCelsiusResponse" />
  </wsdl:message>
  <wsdl:message name="MaxSoapIn">
    <wsdl:part name="parameters" element="tns:Max" />
  </wsdl:message>
  <wsdl:message name="MaxSoapOut">
    <wsdl:part name="parameters" element="tns:MaxResponse" />
  </wsdl:message>
  <wsdl:message name="GetIndexSoapIn">
    <wsdl:part name="parameters" element="tns:GetIndex" />
  </wsdl:message>
  <wsdl:message name="GetIndexSoapOut">
    <wsdl:part name="parameters" element="tns:GetIndexResponse" />
  </wsdl:message>
  <wsdl:message name="HelloWorldSoapIn">
    <wsdl:part name="parameters" element="tns:HelloWorld" />
  </wsdl:message>
  <wsdl:message name="HelloWorldSoapOut">
    <wsdl:part name="parameters" element="tns:HelloWorldResponse" />
  </wsdl:message>
  <wsdl:message name="ReverseSoapIn">
    <wsdl:part name="parameters" element="tns:Reverse" />
  </wsdl:message>
  <wsdl:message name="ReverseSoapOut">
    <wsdl:part name="parameters" element="tns:ReverseResponse" />
  </wsdl:message>
  <wsdl:message name="AverageSoapIn">
    <wsdl:part name="parameters" element="tns:Average" />
  </wsdl:message>
  <wsdl:message name="AverageSoapOut">
    <wsdl:part name="parameters" element="tns:AverageResponse" />
  </wsdl:message>
  <wsdl:portType name="WebServiceSoap">
    <wsdl:operation name="Add">
      <wsdl:input message="tns:AddSoapIn" />
      <wsdl:output message="tns:AddSoapOut" />
    </wsdl:operation>
    <wsdl:operation name="Subtract">
      <wsdl:input message="tns:SubtractSoapIn" />
      <wsdl:output message="tns:SubtractSoapOut" />
    </wsdl:operation>
    <wsdl:operation name="Multiply">
      <wsdl:input message="tns:MultiplySoapIn" />
      <wsdl:output message="tns:MultiplySoapOut" />
    </wsdl:operation>
    <wsdl:operation name="Divide">
      <wsdl:input message="tns:DivideSoapIn" />
      <wsdl:output message="tns:DivideSoapOut" />
    </wsdl:operation>
    <wsdl:operation name="CelsiusToFahrenheit">
      <wsdl:input message="tns:CelsiusToFahrenheitSoapIn" />
      <wsdl:output message="tns:CelsiusToFahrenheitSoapOut" />
    </wsdl:operation>
    <wsdl:operation name="FahrenheitToCelsius">
      <wsdl:input message="tns:FahrenheitToCelsiusSoapIn" />
      <wsdl:output message="tns:FahrenheitToCelsiusSoapOut" />
    </wsdl:operation>
    <wsdl:operation name="CelsiusToKelvin">
      <wsdl:input message="tns:CelsiusToKelvinSoapIn" />
      <wsdl:output message="tns:CelsiusToKelvinSoapOut" />
    </wsdl:operation>
    <wsdl:operation name="KelvinToCelsius">
      <wsdl:input message="tns:KelvinToCelsiusSoapIn" />
      <wsdl:output message="tns:KelvinToCelsiusSoapOut" />
    </wsdl:operation>
    <wsdl:operation name="Max">
      <wsdl:input message="tns:MaxSoapIn" />
      <wsdl:output message="tns:MaxSoapOut" />
    </wsdl:operation>
    <wsdl:operation name="GetIndex">
      <wsdl:input message="tns:GetIndexSoapIn" />
      <wsdl:output message="tns:GetIndexSoapOut" />
    </wsdl:operation>
    <wsdl:operation name="HelloWorld">
      <wsdl:input message="tns:HelloWorldSoapIn" />
      <wsdl:output message="tns:HelloWorldSoapOut" />
    </wsdl:operation>
    <wsdl:operation name="Reverse">
      <wsdl:input message="tns:ReverseSoapIn" />
      <wsdl:output message="tns:ReverseSoapOut" />
    </wsdl:operation>
    <wsdl:operation name="Average">
      <wsdl:input message="tns:AverageSoapIn" />
      <wsdl:output message="tns:AverageSoapOut" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="WebServiceSoap" type="tns:WebServiceSoap">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="Add">
      <soap:operation soapAction="http://tempuri.org/Add" style="document" />
      <wsdl:input>
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output>
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="Subtract">
      <soap:operation soapAction="http://tempuri.org/Subtract" style="document" />
      <wsdl:input>
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output>
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="Multiply">
      <soap:operation soapAction="http://tempuri.org/Multiply" style="document" />
      <wsdl:input>
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output>
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="Divide">
      <soap:operation soapAction="http://tempuri.org/Divide" style="document" />
      <wsdl:input>
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output>
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CelsiusToFahrenheit">
      <soap:operation soapAction="http://tempuri.org/CelsiusToFahrenheit" style="document" />
      <wsdl:input>
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output>
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="FahrenheitToCelsius">
      <soap:operation soapAction="http://tempuri.org/FahrenheitToCelsius" style="document" />
      <wsdl:input>
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output>
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CelsiusToKelvin">
      <soap:operation soapAction="http://tempuri.org/CelsiusToKelvin" style="document" />
      <wsdl:input>
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output>
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="KelvinToCelsius">
      <soap:operation soapAction="http://tempuri.org/KelvinToCelsius" style="document" />
      <wsdl:input>
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output>
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="Max">
      <soap:operation soapAction="http://tempuri.org/Max" style="document" />
      <wsdl:input>
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output>
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetIndex">
      <soap:operation soapAction="http://tempuri.org/GetIndex" style="document" />
      <wsdl:input>
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output>
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="HelloWorld">
      <soap:operation soapAction="http://tempuri.org/HelloWorld" style="document" />
      <wsdl:input>
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output>
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="Reverse">
      <soap:operation soapAction="http://tempuri.org/Reverse" style="document" />
      <wsdl:input>
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output>
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="Average">
      <soap:operation soapAction="http://tempuri.org/Average" style="document" />
      <wsdl:input>
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output>
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:binding name="WebServiceSoap12" type="tns:WebServiceSoap">
    <soap12:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="Add">
      <soap12:operation soapAction="http://tempuri.org/Add" style="document" />
      <wsdl:input>
        <soap12:body use="literal" />
      </wsdl:input>
      <wsdl:output>
        <soap12:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="Subtract">
      <soap12:operation soapAction="http://tempuri.org/Subtract" style="document" />
      <wsdl:input>
        <soap12:body use="literal" />
      </wsdl:input>
      <wsdl:output>
        <soap12:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="Multiply">
      <soap12:operation soapAction="http://tempuri.org/Multiply" style="document" />
      <wsdl:input>
        <soap12:body use="literal" />
      </wsdl:input>
      <wsdl:output>
        <soap12:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="Divide">
      <soap12:operation soapAction="http://tempuri.org/Divide" style="document" />
      <wsdl:input>
        <soap12:body use="literal" />
      </wsdl:input>
      <wsdl:output>
        <soap12:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CelsiusToFahrenheit">
      <soap12:operation soapAction="http://tempuri.org/CelsiusToFahrenheit" style="document" />
      <wsdl:input>
        <soap12:body use="literal" />
      </wsdl:input>
      <wsdl:output>
        <soap12:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="FahrenheitToCelsius">
      <soap12:operation soapAction="http://tempuri.org/FahrenheitToCelsius" style="document" />
      <wsdl:input>
        <soap12:body use="literal" />
      </wsdl:input>
      <wsdl:output>
        <soap12:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CelsiusToKelvin">
      <soap12:operation soapAction="http://tempuri.org/CelsiusToKelvin" style="document" />
      <wsdl:input>
        <soap12:body use="literal" />
      </wsdl:input>
      <wsdl:output>
        <soap12:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="KelvinToCelsius">
      <soap12:operation soapAction="http://tempuri.org/KelvinToCelsius" style="document" />
      <wsdl:input>
        <soap12:body use="literal" />
      </wsdl:input>
      <wsdl:output>
        <soap12:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="Max">
      <soap12:operation soapAction="http://tempuri.org/Max" style="document" />
      <wsdl:input>
        <soap12:body use="literal" />
      </wsdl:input>
      <wsdl:output>
        <soap12:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetIndex">
      <soap12:operation soapAction="http://tempuri.org/GetIndex" style="document" />
      <wsdl:input>
        <soap12:body use="literal" />
      </wsdl:input>
      <wsdl:output>
        <soap12:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="HelloWorld">
      <soap12:operation soapAction="http://tempuri.org/HelloWorld" style="document" />
      <wsdl:input>
        <soap12:body use="literal" />
      </wsdl:input>
      <wsdl:output>
        <soap12:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="Reverse">
      <soap12:operation soapAction="http://tempuri.org/Reverse" style="document" />
      <wsdl:input>
        <soap12:body use="literal" />
      </wsdl:input>
      <wsdl:output>
        <soap12:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="Average">
      <soap12:operation soapAction="http://tempuri.org/Average" style="document" />
      <wsdl:input>
        <soap12:body use="literal" />
      </wsdl:input>
      <wsdl:output>
        <soap12:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WebService">
    <wsdl:port name="WebServiceSoap" binding="tns:WebServiceSoap">
      <soap:address location="http://localhost:51490/WebService.asmx" />
    </wsdl:port>
    <wsdl:port name="WebServiceSoap12" binding="tns:WebServiceSoap12">
      <soap12:address location="http://localhost:51490/WebService.asmx" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>