from django.db import models

# Create your models here.
class Logo(models.Model):
    Name=models.CharField(max_length=100)

class LogoFile(models.Model):
    Logo=models.ForeignKey(Logo)
    FileName=models.CharField(max_length=200)
    BusinessType=models.ForeignKey(BusinessType)

class BusinessType(models.Model):
    Name=models.CharField(max_length=200)