from django.db import models
from organization.models import Organization
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
    '''
    Logo=models.ForeignKey(Logo,blank=True,null=True)
    FileType=models.CharField(max_length=200,null=True)
    FileSize=models.DecimalField( decimal_places=1, max_digits=5,null=True)
    Height=models.IntegerField()
    Width=models.IntegerField()
    Author=models.CharField(max_length=50)
    UploadTime=models.DateTimeField(auto_now=True,null=True)
    DownloadFrom=models.CharField(max_length=1000,null=True)
    '''
    FileName=models.CharField(max_length=100)
    FilePath=models.FileField(upload_to='media')








