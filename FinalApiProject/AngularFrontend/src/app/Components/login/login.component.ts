// Import necessary modules
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  id: any = 'Adarsh';
  password: any = 'Adarsh123';
  loginForm!: FormGroup;

  constructor(private router: Router, private fb: FormBuilder) {}

  ngOnInit() {
    this.loginForm = this.fb.group({
      loginId: ['', Validators.required],
      loginPassword: ['', Validators.required]
    });
  }

  login() {
    if (this.loginForm.valid) {
      const { loginId, loginPassword } = this.loginForm.value;

      if (loginId === this.id && loginPassword === this.password) {
        localStorage.setItem('isLoggedIn', 'true');
        localStorage.setItem('loginId', loginId);
        this.router.navigate(['/dashboard']);
        alert('Login successful..');
      } else {
        localStorage.setItem('isLoggedIn', 'false');
        alert('Invalid credentials! Try again..');
      }
    } else {
      alert('Please fill in all the required fields.');
    }
  }
}
