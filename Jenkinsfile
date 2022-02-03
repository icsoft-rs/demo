pipeline {
    agent any

    stages {
	stage('Dependency') {
            steps {
                echo 'Checking dependencies..'
                sh 'git --version'
                sh 'docker --version'
		        sh 'dotnet --info'
            }
        }
        stage('Build') {
            steps {
                echo 'Building..'
                sh 'chmod +x -R "./build.sh"'
		        sh './build.sh'
            }
        }
        stage('Test') {
            steps {
                echo 'Testing..'
            }
        }
        stage('Deploy') {
            steps {
                echo 'Deploying....'
            }
        }
    }
}
