import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';

@Component({
  selector: 'app-manage-country',
  templateUrl: './manage-country.component.html',
  styleUrls: ['./manage-country.component.css']
})
export class ManageCountryComponent implements OnInit {

  form!: FormGroup;

  constructor() { }

  ngOnInit(): void {
    this.form = new FormGroup({
      categoryName: new FormControl('', [Validators.required]),
      categoryDescription: new FormControl('', Validators.required)
    });
  }

}
