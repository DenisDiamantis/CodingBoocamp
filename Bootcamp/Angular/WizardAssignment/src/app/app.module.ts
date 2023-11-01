import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PersonalDetailsComponent } from './personaldetails/personaldetails.component';
import { ContactDetailsComponent } from './contactdetails/contactdetails.component';
import { SkillsComponent } from './skills/skills.component';
import { WorkExperienceComponent } from './workexperience/workexperience.component';
import { WizardFinishedComponent } from './wizardfinished/wizardfinished.component';
import { WelcomeComponent } from './welcome/welcome.component';

@NgModule({
  declarations: [
    AppComponent,
    PersonalDetailsComponent,
    ContactDetailsComponent,
    SkillsComponent,
    WorkExperienceComponent,
    WizardFinishedComponent,
    WelcomeComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
