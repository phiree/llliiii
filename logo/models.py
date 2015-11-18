from django.db import models
from enum import Enum
# Create your models here.
class Logo(models.Model):
    """Logo concept"""
    Name=models.CharField(max_length=100)
    Owner=models.ForeignKey(Organization)
    Description=models.CharField(max_length=2000)

class LogoFile(models.Model):
    """
    File of a logo
    """
    Logo=models.ForeignKey(Logo)
    FileName=models.CharField(max_length=200)
    FileType=models.CharField(max_length=200)
    FileSize=models.DecimalField()
    Height=models.IntegerField()
    Width=models.IntegerField()
    Author=models.CharField(max_length=50)
    UploadTime=models.DateTimeField(auto_now=True)
    DownloadFrom=models.CharField(max_length=1000)





class Organization(models.Model):
    """组织"""
    Name=models.CharField(max_length=100)
    Type=models.IntegerField()
    Creator=models.CharField(max_length=200)
    CreatedTime=models.DateTimeField()
    Description=models.CharField(max_length=4000)


class OrganizationType(Enum):
    """组织类型"""
    Enterprise=1  #企业
    NonProfit=2   #非盈利企业
    WorkShop=3    #工作室
    Individual=3 # 个人
    Goverment=4  #政府
    Other=99     #其他


class IndustryType(models.Model):
    """行业分类"""
    Name=models.CharField(max_length=200)
    Parent=models.ForeignKey("self")

class Organization_IndustryType(models.Model):
    """组织的 行业类型 多对多"""
    IndustryType=models.ForeignKey(IndustryType)
    Organization=models.ForeignKey(Organization)


