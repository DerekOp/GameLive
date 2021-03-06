"""
Definition of urls for GameLiveDjango.
"""

from datetime import datetime
from django.urls import path

from django.contrib import admin
from django.conf.urls import include
admin.autodiscover()
from django.contrib.auth.views import LoginView, LogoutView
from app import forms, views


urlpatterns = [
    path('', views.home, name='home'),
    path('contact/', views.contact, name='contact'),
    path('about/', views.about, name='about'),
    path('library/', views.library, name='library'),
    path('login/',
         LoginView.as_view
         (
             template_name='app/login.html',
             authentication_form=forms.BootstrapAuthenticationForm,
             extra_context=
             {
                 'title': 'Log in',
                 'year' : datetime.now().year,
             }
         ),
         name='login'),
    path('logout/', LogoutView.as_view(next_page='/'), name='logout'),
    path('admin/', admin.site.urls),
   # url(r'^admin/doc/', include('django.contrib.admindocs.urls')),
   # url(r'^admin/', include(admin.site.urls)),
]
