// add-graduate-trainee.component.ts
import { HttpClient } from "@angular/common/http";
import { Component, OnInit } from "@angular/core";
import { FormBuilder, FormGroup, Validators } from "@angular/forms";
import { Router } from "@angular/router";
import { GraduateTraineeService } from "src/app/graduate-trainee.service";

@Component({
  selector: 'app-add-graduate-trainee',
  templateUrl: './add-graduate-trainee.component.html',
  styleUrls: ['./add-graduate-trainee.component.css']
})
export class AddGraduateTraineeComponent implements OnInit {
  model:any[]=[];
  graduateTraineeForm: FormGroup = this.fb.group({
    degreeId: ['', Validators.required],
    graduateTraineeName: ['', Validators.required],
    graduateTraineeEmail: ['', [Validators.required, Validators.email]],
    universityName: ['', Validators.required],
    isLastSemesterPending: [true, Validators.required],
    gender: ['', Validators.required],
    dateOfApplication: [ '',Validators.required],
    image: [''],
    ai: ['', Validators.required],
    python: ['', Validators.required],
    businessAnalysis: ['', Validators.required],
    machineLearning: ['', Validators.required],
    practical: ['', Validators.required],
  });

  successMessage: boolean = false;


  constructor(private fb: FormBuilder, private http: HttpClient,private router: Router,private service :GraduateTraineeService) {}
ngOnInit(): void {
this.service.GetAllDegreesID()
.subscribe({
  next:(respone)=>{
    this.model=respone;
    console.log(this.model);
  }
})}
  onSubmit() {
    if (this.graduateTraineeForm.valid) {
      const apiUrl = 'http://localhost:5038/api/GraduateTrainee/Create';
      const formData = this.graduateTraineeForm.value;

      this.http.post(apiUrl, formData).subscribe({
        next: (response) => {
          console.log('API Response:', response);
          this.graduateTraineeForm.reset();
          this.showSuccessMessage();
        },
        error: (error) => {
          console.error('API Error:', error);
        }
      });
    }
  }

  private showSuccessMessage() {
    this.successMessage = true;
    setTimeout(() => {
      this.successMessage = false;
    }, 3000); // Hide the success message after 3 seconds (adjust as needed)
  }

  redirectToDashboard() {
    this.router.navigate(['/dashboard']); // Update with your actual dashboard route
  }
}
