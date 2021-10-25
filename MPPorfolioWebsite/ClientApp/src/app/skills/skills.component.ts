import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-skills',
  templateUrl: './skills.component.html',
})
export class SkillsComponent {
  public skills: Technologies[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Technologies[]>(baseUrl + 'home/getTechnologies').subscribe(result => {
      this.skills = result;
    }, error => console.error(error));
  }
}


interface Technologies {
  icon: string;
  name: string;
  description: string;
}
