#include "DS1820.h"
#include "stm32f10x_gpio.h"
#include "tty.h"
/******************************************************************************************************************************/
uint8_t DS18B20_Rst(void)			   //ds18b20��ʼ������
{
	 u8 success;
	 success=0;
   DS1820_DQ_H;
   DelayUs(30);
   DS1820_DQ_L;
   DelayUs(500);
   DS1820_DQ_H;
   DelayUs(40);
	 if(DS1820_READ_PIN){};
	 DelayUs(500);
	 DS1820_DQ_H;
	 return success;
}
//��DS18B20��ȡһ���ֽ�
//����ֵ������������
uint8_t DS18B20_Read_Byte(void)    // read one byte
{        
    uint8_t i,dat;
    dat=0;
		DS1820_DQ_H;
		DelayUs(5);
		for (i=1;i<=8;i++) 
		{
					DS1820_DQ_L;
					DelayUs(5);
					dat>>=1;
					DS1820_DQ_H; 
					DelayUs(5);
					if(DS1820_READ_PIN){
						dat|=0x80;
					}else{
						dat&=0x7f;
					}
					DelayUs(65);
					DS1820_DQ_H; 
			}						    
			return dat;
}

//дһ���ֽڵ�DS18B20
//dat��Ҫд����ֽ�
void DS18B20_Write_Byte(u8 dat)     
 {             
    uint8_t j;
    uint8_t testb;
    for (j=1;j<=8;j++) 
		{
        testb=dat&0x01;        
				DS1820_DQ_L;
				DelayUs(5);
				dat=dat/2;
        if (testb) // Write 1
        {
						DS1820_DQ_H;             
        }
        else // Write 0
        {
            DS1820_DQ_L;
                   
        }
				DelayUs(65);             
				DS1820_DQ_H;
				DelayUs(2);
    }
		DelayUs(25); 
}
//��ʼ��DS18B20��IO�� DQ ͬʱ���DS�Ĵ���
//����1:������
//����0:����    	 
uint8_t DS18B20_Init(void)
{
    GPIO_InitTypeDef GPIO_InitStructure;
		GPIO_InitStructure.GPIO_Pin=DS1820_DQ ;
    GPIO_InitStructure.GPIO_Mode=GPIO_Mode_Out_OD;  //��˵OD��©����stm32IO�ɳ�˫��
    GPIO_InitStructure.GPIO_Speed=GPIO_Speed_50MHz;
    GPIO_Init(DS1820_GPIO, &GPIO_InitStructure); 
		return 1;
}
/*****************************
//��ds18b20�õ��¶�ֵ
//���ȣ�0.1C
//arg: buffer,it's size is 10
//����ֵ���¶�ֵ ��-550~1250��
*******************************/
int DS18B20_Get_Temp(u8 *temp,u8 len)
{
    uint8_t TL,TH,tf,td,k;
		if(len!=11){
			return 0;
		}
		*temp++='W';
		*temp++='D';
		*temp++=':';
		DS18B20_Rst();
    DS18B20_Write_Byte(0xcc);// skip rom
    DS18B20_Write_Byte(0x44);// convert	 
		DelayMs(10);
		DS18B20_Rst();
    DS18B20_Write_Byte(0xcc);// skip rom
    DS18B20_Write_Byte(0xbe);// read tempereture reg	 
    TL=DS18B20_Read_Byte(); // LSB
    TH=DS18B20_Read_Byte(); // MSB  

		tf=TL&0x0f;						  //tf��ʾС������
		td=TH*16+TL/16;
		//��������
		k=td/100;
		k=k+'0';
		*temp++=k;
		k=(td%100)/10;
		k=k+'0';
		*temp++=k;
		k=td%10;
		k=k+'0';
		*temp++=k;
		*temp++='.';
		//С������
		tf=tf*62.5;
		k=tf/100;
		k=k+'0';
		*temp++=k;
	  k=tf%100/10;
		k=k+'0';
		*temp++=k;
		//k=tf%10;
		//k=k+'0';
		*temp++='\n';
		*temp++='\0';
		return 1;
}
