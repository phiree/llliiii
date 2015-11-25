from django.shortcuts import render
from logo.models import LogoFile
# Create your views here.
def home(request):
    files=LogoFile.objects.all()
    return render(request,"home.html",{"files":files})
    pass
