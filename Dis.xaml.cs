using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace _8th_Sem_Project
{
    public partial class Dis : PhoneApplicationPage
    {
        string text;
        String a = _8th_Sem_Project.Sva_Chikitsa.Diseases.Disease.disea;

        public Dis()
        {
            InitializeComponent();
        }
       
         protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            disPanorama.Title = a;
            p1.Header = "Description";
            p2.Header = "Symptoms";
            p3.Header = "Tests";
            p4.Header = "Treatment";
            p5.Header = "Pics";
            p6.Header = "Videos";
          
           if (a == "Arthritis")

            {   
this.T1.Text = "Inflammation of a single joint or multiple joints. There are many causes including infection, and inflammatory conditions such as: osteoarthritis, gout, pseudogout, rheumatoid arthritis, lupus, ankylosing spondylitis, and psoriasis.";
                    this.T2.Text = " Joint pain, joint swelling, redness, increased warmth, decreased motion.";
                    this.T3.Text = "A history and physical exam will be performed. Blood tests and/or analysis of joint fluid will be done to determine cause of arthritis. Imaging studies may also be beneficial.";
                    this.T4.Text = " Antinuclear antibody (ANA), Complete blood count (CBC), Comprehensive metabolic panel (CMP), Erythrocyte sedimentation rate (ESR), Rheumatoid factor (RF) and X-ray";
                    this.T5.Text = " Family Medicine, Internal Medicine, Orthopedic Surgery, Pediatric Rheumatology, Pediatrics and Rheumatology";
                    this.T6.Text = " Determined by the type of arthritis. If the joint is infected, the main treatment is antibiotics and removal of joint fluid. For other types of arthritis, treatment may include but may include: nonsteroidal anti-inflammatory medications/NSAIDs (ibuprofen/Motrin or Advil, naproxen/Naprosyn or Aleve), acetaminophen (Tylenol), sulfasalazine, corticosteroids (prednisone), methotrexate, biological therapy and/or immunotherapy. ";         
           }

            else if (a == "high cholestrol)")
            {   
                    this.T1.Text=" Elevated levels of cholesterol in the blood increases the risk of having narrowed arteries. The blockage is caused by a buildup of plaque and fat deposits (atherosclerosis). The diseases caused by this narrowing are dependent on the arteries being blocked but include: heart attacks, strokes, and peripheral vascular disease. People with elevated cholesterol also are likely to suffer from high blood pressure and diabetes. There are two types of cholesterol that make up the total level of cholesterol, LDL and HDL. LDL is considered bad cholesterol and HDL is good cholesterol. To know a patient's true risk of disease the provider must send a blood test that measures both LDL and HDL. In general the LDL should be less than 130 mg/dL and anything greater than 160 mg/dL is considered too high. An HDL level lower than 40 mg/dL increases the risk of atherosclerosis. A person's cholesterol level is determined in part by inheritance, and in part by the foods he or she eats. Improving one's diet and/or medications can generally reduce the levels.";
                    this.T2.Text = " There are usually no symptoms related to having elevated cholesterol.";
                    this.T3.Text = " A history and physical exam will be done. Blood levels will be done to measure total cholesterol, LDL and HDL. A triglyceride level is usually checked as well.";
                    this.T4.Text = " Cholesterol panel (LDL, HDL, total cholesterol, triglyceride)";
                    this.T5.Text = " Family Medicine, Internal Medicine and Pediatrics";
                    this.T6.Text = " Treatment depends on how high the LDL level is and if other risk factors for developing blockage of the arteries (atherosclerosis) are present. Eating healthy foods, exercising more, and losing weight can improve mild elevations of cholesterol. Other treatments include medications such as statins (atorvastatin/Lipitor, fluvastatin/Lescol, lovastatin/Altocor or Mevacor, pravastatin/Pravachol, rosuvastatin/Crestor, simvastatin/Zocor), bile acid binding drugs (cholestyramine/Prevalite or Questran, colesevelam/Welchol, colestipol/Colestid), cholesterol absorption inhibitors (ezetimibe/Zetia) and combination drugs (ezetimibe-simvastatin/Vytorin).";
            }
        
            else if (a == "high blood pressure")
            {   
                    this.T1.Text=" A termed used for high blood pressure. There are two numbers with the first number representing the systolic pressure (normal less than 140) and the second number the diastolic (normal if less than 90). Hypertension usually causes no symptoms but is a major risk factor for a number of serious long term problems including heart attacks, stroke and kidney failure.";
                    this.T2.Text = " Usually none. If the level is very high the following may be experienced: chest pain, headache, shortness of breath, visual complaints, confusion. ";
                    this.T3.Text = "A history and physical exam will be performed. Tests may be performed to look for causes of hypertension or organ damage related to hypertension.";
                    this.T4.Text = "Complete blood count (CBC), Comprehensive metabolic panel (CMP), Electrocardiogram (EKG) and X-ray.";
                    this.T5.Text = " Cardiology, Family Medicine, Internal Medicine and Pediatrics";
                    this.T6.Text = "Treatment includes salt restriction, loss of excess weight, exercise and, in many cases, medications to reduce the pressure.";
            }
        
            else if (a == "cellulitis")
            {   
                    this.T1.Text=" A skin infection usually caused by bacteria. Bacteria can enter into the skin through a cut or insect bite and spread to deeper tissues causing an infection. If it is not treated with antibiotics, the infection can spread to the blood or lymph nodes. The most common bacteria are staphylococcus and streptococcus species. A particular staphylococcus species called Methicillin-resistant Staphylococcus aureus (MRSA) is becoming a more common cause. People with depressed immune systems as with diabetes, cancer, HIV, chronic steroid use, and autoimmune diseases are more likely to develop cellulitis";
                    this.T2.Text = " The affected skin becomes painful, red, warm to the touch, and swollen. If the surrounding lymph channels become infected red streaks up the arm or leg will be seen. These red streaks are called lymphangitis. Patients may also experience fever and fatigue.";
                    this.T3.Text = " A history and physical exam will be performed. Blood counts and blood cultures may also be performed.";
                    this.T4.Text = " ";
                    this.T5.Text = " Family Medicine, Infectious Disease Medicine, Internal Medicine, Pediatric Infectious Disease Medicine and Pediatrics";
                    this.T6.Text = " Cleaning and bandaging of any lacerations or abrasions will be done. Removal of the stinger will be performed if the infection is from an insect bite. Antibiotics are routinely recommended for cellulitis and may be administered orally or intravenously, depending on the severity of the infection. Common antibiotics include: cephalexin/Keflex, dicloxacillin/Dynapen, clindamycin/Cleocin, or clarithromycin/Biaxin. If MRSA is suspected the following antibiotics may be used: trimethoprim and sulfamethoxazole/Bactrim, vancomycin/Vancocin, daptomycin/Cubicin, tigecycline/Tygacil, or linezolid/Zyvox.";
                    

            }
        
            else if (a == "lumbago")
            {   
                    this.T1.Text=" Low back pain is pain in the lower (lumbar) area of the spine and is defined as chronic if the symptoms last longer than three months. Over time gravity and normal use can result in the gradual degeneration of the spine. A variety of spinal structures are affected by this steady gravitational pull and their degeneration is thought to cause low back pain. Strains and other injuries to the bones, ligaments, muscles and intervertebral disks in the spine are commonly diagnosed along with arthritis all of which lead to low back pain. Low back pain is the most common cause of disability in Americans younger than 45..";
                    this.T2.Text = " Symptoms include back pain, pain radiating down the leg, decreased flexibility, pain with movement, and occasionally numbness and weakness.";
                    this.T3.Text = " A history and physical will be performed. Imaging tests and possibly blood samples may be performed depending on the severity and extent of symptoms..";
                    this.T4.Text = " CT Scan, Magnetic resonance imaging (MRI), Urinalysis (UA) and X-ray ";
                    this.T5.Text = " Family Medicine, Internal Medicine, Neurosurgery, Pain Medicine, Physical Medicine and Rehabilitation (physiatry) and Spine Surgery";
                    this.T6.Text = " Therapy depends on the extent of the disease and symptoms. Treatment may include: pain medications, muscle relaxants, non-steroidal anti-inflammatory medications (ibuprofen/Motrin or Advil, naproxen/Naprosyn), acetaminophen (Tylenol), exercise and physical therapy. Epidural steroid injections and/or surgery may be considered for persistent pain. Numbness, weakness, or loss of bowel or bladder control may require emergent surgery";
           }
        
            else if (a == "LUpus")

            {   
this.T1.Text=" A chronic inflammatory autoimmune disorder that may affect the skin, joints, kidneys, and other organs. The disease is thought to be due to misfiring of the body's immune system so that it attacks organs of the body. The result is chronic (long-term) inflammation that can affect many parts of the body, including arthritis, skin rash, kidney disease, brain inflammation, and heart problems.";
                this.T2.Text = " Symptoms are highly variable but may include: fever, fatigue, general discomfort, skin rash (butterfly rash over the cheeks and bridge of the nose affects about half of those with SLE), sensitivity to sunlight, joint pain and swelling, swollen glands, muscle aches, nausea, chest pain with breathing, seizures, psychosis.";
                    this.T3.Text = " A history and physical exam will be performed. Tests used to diagnose SLE may include blood tests (including an antibody called antinuclear antibody, or ANA, that is present in nearly all people with lupus), urine tests, imaging, and/or a kidney biopsy.";
                    this.T4.Text = " Complete blood count (CBC), Comprehensive metabolic panel (CMP), Electrocardiogram (EKG), Urinalysis (UA) and X-ray";
                    this.T5.Text = " Internal Medicine, Pediatric Rheumatology and Rheumatology";
                   this.T6.Text = " There is no cure for lupus. Treatment is provided to control symptoms and is based on the severity of those symptoms. Treatment may include: nonsteroidal anti-inflammatory medications/NSAIDs (ibuprofen/Motrin or Advil, naproxen/Naprosyn), pain medications such as acetaminophen (Tylenol), corticosteroid creams, an anti-malaria drug (hydroxychloroquine), methotrexate, azathioprine and/or oral steroids. Severe or life-threatening symptoms (such as hemolytic anemia, extensive heart or lung involvement, kidney disease, or central nervous system involvement) may require high dose steroids, cytotoxic medications (such as cyclophosphamide/Cytoxan) and other drugs to inhibit the immune system.";
                
            }
       
            else if (a == "Obesity")

            {   
this.T1.Text=" Defined as an increase in total body fat, or at least a 20% increase in one's ideal body weight. Obesity has increased in frequency in the last 20 years and it is estimated 33% of Americans are obese. One calculation of obesity is the body mass index or BMI. To calculate the BMI, people take their weight in pounds and multiplies it by 705, then divides this number by their height in inches, then divides this number again by their height in inches. The US Department of Health and Human Services provides a BMI calculator at http://www.nhlbisupport.com/bmi/. A normal BMI = 18.5-24.9; overweight = 25.0-29.9; obese = 30 or greater; and morbidly obese = 40 or greater. Obesity is the second leading cause of preventable death (after smoking), and is associated with type 2 diabetes, elevated cholesterol, heart disease, arthritis, gallstones, obstructive sleep apnea, and cancer. There are many causes of obesity from genetic to environmental factors, and certain conditions including Cushing's syndrome, hypothyroidism and medications, such as steroids, can cause obesity. In the great majority of cases no secondary cause is determined..";
                this.T2.Text = " Most of the symptoms of obesity come from the diseases obesity causes such as arthritis, heart disease, gallstones, sleep apnea, and poor self-esteem. These symptoms include: back pain, hip pain, knee pain, ankle pain, neck pain, chest pain, breathing problems, sadness, depression, snoring, rashes in the folds of the skin, and excessive sweating.";
                    this.T3.Text = " A history and physical exam will be done. Other tests may be performed to determine the cause of the excess body fat. A BMI will be calculated";
                    this.T4.Text = " Thyroid function tests, Fasting glucose, cholesterol, triglycerides";
                    this.T5.Text = "Bariatric Medicine, Bariatric Surgery, Diabetes, Endocrinology and Metabolism, Family Medicine, Internal Medicine and Pediatrics";
                    this.T6.Text = "Treatment is aimed at decreasing the intake of calories while still maintaining a healthy diet, and increasing exercise. Successful programs for weight loss should be started and followed under the care of a physician and/or a nutritionist. Behavioral modification therapy and social support can help achieve positive results. Medications can be used and include orlistat, bupropion, lorcaserin, phentermine and diethylpropion. Bariatric surgery such as gastric bypass and lap band procedures have been found to be effective. They are usually reserved for those patients with BMIs greater than 40, or for those with a BMI between 35-40 and with a co-existing obesity related medical problem such as diabetes";                
            }
        
            else if (a == "STD")

            {   
this.T1.Text=" Any one of a group of diseases that may be caused by viruses or bacteria and are spread during sexual activity. They typically cause symptoms of the genitalia or urinary tract, but many are asymptomatic. They may also lead to generalized disease, particularly in the chronic form. Having more than one sexual partner increases the risk of acquiring the disease. The most common STDs are chlamydia, gonorrhea, viral hepatitis, genital herpes, HIV/AIDS, human papillomavirus, pelvic inflammatory disease, syphilis, and trichomoniasis.";
                this.T2.Text = " Symptoms depend on the infecting agent, but may include: penile discharge, painful urination, painful sores on the genitalia, pimples on the genitalia, pain with sexual intercourse";
                    this.T3.Text = " A history and physical exam will be performed. Penile, urinary, rectal, cervical, or pharyngeal cultures are performed to identify the infecting organism. Syphilis is diagnosed with a blood test (RPR, VDRL).";
                    this.T4.Text = " Cervical culture, throat culture, Urinalysis (UA) and Urine Culture, RPR, VDRL";
                    this.T5.Text = " Family Medicine, Infectious Disease Medicine, Internal Medicine, Pediatric Infectious Disease Medicine and Pediatrics";
                   this.T6.Text = " Treatment depends on the organism causing the infection but may include: antibiotics, or anti-viral medications.";
                      }
       

            else if (a == "Alcoholism")

            {   
this.T1.Text=" A physical and mental dependence on alcohol, sometimes resulting in chronic disease and the loss of interpersonal, family and work relationships. Continued daily use can result in permanent damage to the liver (cirrhosis). Other long term effects include: anemia, internal bleeding, impaired thinking, confusion, coma, multiple cancers, and premature death.";
                this.T2.Text = " Weakness, impaired thinking, poor decision making, depression, separation from family.";
                    this.T3.Text = " A history and physical exam will be performed along with other tests which may include: a complete blood count, liver function tests, blood sugar, and electrolytes.";
                    this.T4.Text = " Complete blood count (CBC), Comprehensive metabolic panel (CMP) and Lipase ";
                    this.T5.Text = " Family Medicine, Internal Medicine and Psychiatry";
                   this.T6.Text = " Treatment includes individual and/or group counseling (such as AA), talk therapy ,and/or medications. ";
            }
        
if (a == "Anxiety disorder")
            {
                    this.T1.Text =" A disorder characterized by persistent exaggerated worry and tension without any clearly identifiable reason. There is a sense of fear or apprehension accompanied by some or all of the following signs: muscle tension, restlessness, palpitations, rapid breathing, jitteriness, suspicion, confusion, decreased concentration, or fear of losing control. The exact cause of this disorder is not known but it is likely related to both genetic and environmental factors..";
                    this.T2.Text = " Fear, apprehension, muscle tension, restlessness, palpitations, rapid breathing, jitteriness, hyper vigilance, confusion, decreased concentration, fear of losing control.";
                    this.T3.Text = " A history and physical exam will be performed both to make the diagnosis and to identify potential triggers that make symptoms worse..";
                    this.T4.Text = " if necessary, BHCG, Complete blood count (CBC), Comprehensive metabolic panel (CMP), CT Scan and Urinalysis (UA), blood alcohol, drug screen test.";
                    this.T5.Text = " Family Medicine, Internal Medicine, Pediatric and Adolescent Psychiatry, Pediatrics and Psychiatry.";
                    this.T6.Text = "Therapy depends on the severity of symptoms. Treatment may include: an SSRI antidepressant medication, short term use of a benzodiazepine (diazepam/Valium, lorazepam/Ativan), psychological counseling, and/or cognitive behavioral therapy.";
            }
            else if (a == "depression")
            {   
this.T1.Text="A mental state or chronic psychiatric disorder characterized by excessive feelings of sadness, loneliness, despair, helplessness, low self-esteem, and self-reproach. Depression is different than normal sadness because it prevents the person from functioning normally in their daily life. Other signs of depression include a lack of energy or initiative (psychomotor retardation), agitation, withdrawal from social contact, insomnia, decreased appetite and/or a vegetative state. The symptoms can become severe enough to cause self-harm or suicide. Any patient having thoughts their life is not worth living needs to get immediate medical help.";
                this.T2.Text = "Patients suffering from the following symptoms may have depression: excessive sadness, problems falling asleep, sleeping too much, problems concentrating, uncontrollable negative thoughts, no appetite, short temper, feeling helpless, increase in drinking alcohol, increase reckless behavior, increased fatigue, thoughts life isn't worth living";
                    this.T3.Text = " A history and physical exam will be performed. Additional tests may include: thyroid function tests, electrolytes, or a brain CT scan..";
                    this.T4.Text = " Comprehensive metabolic panel (CMP), CT Scan and Thyroid function tests";
                    this.T5.Text = " Family Medicine, Geriatric Psychiatry, Internal Medicine, Pediatric and Adolescent Psychiatry, Pediatrics and Psychiatry";
                    this.T6.Text = "Antidepressants and/or psychotherapy are the mainstays of treatment. Psychiatric hospitalizations may be needed for severe symptoms and for those with suicidal thoughts. For patients who fail to respond to medications and psychotherapy electroconvulsive treatment (ECT) may be an option. Any patient who feels life is not worth living needs to seek medical care immediately";
            }
        
else if (a == "diabetis")
            {
                    this.T1.Text =" A chronic disease of metabolism distinguished by the body's inability to produce enough insulin, and/or a resistance to the insulin being made. Insulin is necessary for body cells to transport sugar into the cells and to process carbohydrates, fat, and protein efficiently. Patients with diabetes have too much glucose in their circulation causing damage to almost every organ in their body. There are three types of diabetes: Type 1 is usually found in younger patients and requires insulin, Type 2 develops later in life and is more commonly associated with obesity, and gestational diabetes is associated with pregnancy.";
                    this.T2.Text = " Increased urination, increased drinking of fluids, increased appetite, nausea, fatigue, blurry vision, numbness or tingling in the feet.";
                    this.T3.Text = " A history and physical exam will be performed. Glucose measurements are performed randomly and as a fasting level first thing in the morning. A hemoglobin A1C can measure the average glucose level over time. With very high glucose levels or high acid levels in the body, serum ketones and an arterial blood gas may be measured to rule out a serious complication called diabetic ketoacidosis (DKA).. ";
                    this.T4.Text = "Comprehensive metabolic panel (CMP), Hemoglobin A1c (HbA1c) and Urinalysis (UA), Serum ketones, arterial blood gas";
                    this.T5.Text = " Diabetes, Endocrinology and Metabolism, Family Medicine, Internal Medicine, Pediatric Endocrinology and Pediatrics.";
                    this.T6.Text = "Type 1 diabetes requires supplemental insulin either as an injection or as an intermittent continuous infusion delivered from an insulin pump. The insulin doses required are dependent on glucose measurements performed during the day. Sometimes, type 2 diabetes can be controlled with weight loss, dietary discretion and exercise. Type 2 diabetes often requires oral hypoglycemic medications and may also require insulin. ";
            }
            























}
	}
}